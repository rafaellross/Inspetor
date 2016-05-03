using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InspetorXML_Console.Classes.App;
using InspetorXML_Console.Classes.XML;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace InspetorXML_Console.Classes.ERP.Generico
{
    public class Erp
    {
        private List<XmlNfe> arquivosXml;
        private DB dbErp;
        private Parametros parametros;
        private DB dbInspetor;

        public Erp(List<XmlNfe> arquivosXml, DB dbErp, Parametros parametros, DB dbInspetor)
        {
            this.parametros = parametros;
            this.arquivosXml = arquivosXml;
            this.dbErp = dbErp;
            this.parametros = parametros;
            this.dbInspetor = dbInspetor;
        }
        
        //Esta função verifica se a nota já foi lançada no Erp e retorna true ou false
        public bool verificaProcessado(string chaveNfe, string tpNF, string TabEmpresa = "")
        {
            int consulta;

            if (this.parametros.TipoErp.ToString().ToLower() == "protheus")
            {
                if (tpNF == "ENTRADA")
                {                                                            
                    consulta = this.dbErp.consultaErp("SELECT F1_CHVNFE FROM SF1" + TabEmpresa + "0 WHERE F1_CHVNFE = '" + chaveNfe + "'  AND D_E_L_E_T_ <> '*'").Count;
                }
                else
                {
                    consulta = this.dbErp.consultaErp("SELECT F2_CHVNFE FROM SF2" + TabEmpresa + "0 WHERE F2_CHVNFE = '" + chaveNfe + "'  AND D_E_L_E_T_ <> '*'").Count;
                }
                
            }
            else
            {
                //TODO: CRIAR CONSULTA DO RM
                consulta = dbErp.execQuery("CRIAR CONSULTA DO RM AQUI").Count;
            }
            
            if (consulta > 0)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }

        public void escreveLog(string titulo, string msg)
        {
            string DataAtual = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            string arquivoLog = parametros.PastaLog + "\\LogInspetor.log";
            if (Convert.ToInt32(this.parametros.ativaLog) == 1)
            {
                if (! System.IO.File.Exists(arquivoLog))
                {
                    System.IO.File.Create(arquivoLog);
                }
                StreamWriter stream = new StreamWriter(arquivoLog, true);
                stream.WriteLine(DataAtual + " -- : " + titulo + " ---------- " + msg);                
                stream.Close();
            }
        }

        public void inicia()
        {
            foreach (var nota in this.arquivosXml)
            {

                //Faz as críticas
                //Verifica se a nota já foi lançada ou se esta com crítica      
                bool xmlProcessado = false;
                if (nota.CodEmpErp != null)
                {
                    xmlProcessado = this.verificaProcessado(nota.ChaveNfe, nota.TipoNf, nota.CodEmpErp);
                }
                
                if (xmlProcessado || nota.xmlCriticado)
                {
                    
                    nota.xmlCriticado = true;

                    if (xmlProcessado)
                    {
                        this.escreveLog("Arquivo " + nota.nomeArquivo + " criticado", "JA FOI LANCADO NO SISTEMA");
                        //Caso a nota já tenha sido lançada, será criado um log
                        var qryJaLancado = "INSERT INTO CRITICAXML (CODFILIAL, NOME_XML, DATAEMISSAO, SETOR, CNPJ, RAZAO, CRITICA, TIPO, CNPJINTERNO, GRUPO) VALUES " +
                                        "('" + nota.CodFilErp + "', '" + nota.nomeArquivo.Replace(this.parametros.PastaProcessar, this.parametros.PastaCriticados) + "', '" + nota.DataEmissao + "', 'CMP', '" + nota.CnpjCliFor + "', " +
                                        "'" + nota.nomeCliFor + "', 'XML TRANSFERIDO PARA A PASTA CRITICADOS, O MESMO JA FOI LANCADO NO SISTEMA.', 'C', '" + nota.cnpjInterno + "', '" + nota.CodEmpErp +"')";

                        this.dbInspetor.execQuery(qryJaLancado);

                        //Move o arquivo para a pasta de criticados
                        Console.ForegroundColor = System.ConsoleColor.Yellow;
                        FuncoesErp.movePara(nota.nomeArquivo, parametros.PastaCriticados);
                        Console.WriteLine(nota.nomeArquivo + " | XML TRANSFERIDO PARA A PASTA CRITICADOS, O MESMO JA FOI LANCADO NO SISTEMA.");
                        Console.ForegroundColor = System.ConsoleColor.Gray;
                    }
                    else
                    {
                        this.escreveLog("Arquivo " + nota.nomeArquivo + " criticado", nota.msgCritica);
                        Console.ForegroundColor = System.ConsoleColor.Red;

                        FuncoesErp.movePara(nota.nomeArquivo, this.parametros.PastaCriticados);
                        Console.WriteLine(nota.nomeArquivo + " | " + nota.msgCritica.ToUpper());                        
                        Console.ForegroundColor = System.ConsoleColor.Gray;
                        this.dbInspetor.execQuery("INSERT INTO LOGEVENTOSXML (NOME_XML, DATAEMISSAO, SETOR, USUARIO, EVENTO, CRITICA) " +
                                              "VALUES ('" + nota.nomeArquivo.Replace(this.parametros.PastaProcessar, this.parametros.PastaCriticados) + "',GETDATE(), 'FIS', '" + parametros.User + "', 'I', '" + nota.msgCritica + "')");
                    }
                    continue;
                }

                //Caso hajam críticas, move arquivo para a pasta de críticados

                if (nota.xmlCriticado)
                {
                    //Move o arquivo para a pasta de criticados
                    FuncoesErp.movePara(nota.nomeArquivo, parametros.PastaCriticados);                    
                    continue;
                }

                //Verifica o cliente/fornecedor 
                if (!nota.xmlCriticado)
                {
                    //Atribui o código e filial da empresa que está no ERP
                    var CodEmpErp = nota.CodEmpErp;
                    var CodFilErp = nota.CodFilErp;

                    
                    List<string> verificaCliFor = new List<string>();
                    string sqlVerificaCliFor = FuncoesErp.sqlCliForErp(this.parametros.TipoErp, nota.TipoNf, nota.CnpjCliFor, nota.CodEmpErp, nota.CodFilErp, nota.nomeCliFor, nota.Exportacao);
                    verificaCliFor = this.dbErp.consultaErp(sqlVerificaCliFor);

                    if (verificaCliFor.Count == 0)
                    {
                        this.dbErp.insere(FuncoesErp.sqlInsertCliFor(nota.tipoErp, nota), "InsereCliFor");
                        var color = Console.ForegroundColor;
                        Console.ForegroundColor = System.ConsoleColor.Blue;
                        Console.WriteLine("O Cliente/Fornecedor foi criado, pois não existia no ERP");
                        Console.ForegroundColor = color;
                        this.escreveLog("Arquivo " + nota.nomeArquivo + "", "O Cliente/Fornecedor foi criado, pois não existia no ERP");
                        verificaCliFor = this.dbErp.consultaErp(sqlVerificaCliFor);
                    }

                    if (verificaCliFor.Count > 0 && verificaCliFor[2] == "2")
                    {
                        nota.CodCliForErp = verificaCliFor[0];
                        nota.CodLojaCliForErp = verificaCliFor[1];
                        nota.CodCondPagto = verificaCliFor[3];
                        nota.CodTipoCliFor = verificaCliFor[4];
                    }
                    else
                    {
                        nota.xmlCriticado = true;
                        //2 = DESBLOQUEADO / 1 = BLOQUEADO
                        //Verifica se o Cli/For está bloqueado
                        string logMsg = "O CLIENTE/FORNECEDOR NÃO EXISTE NA BASE DE DADOS DO ERP | " + nota.ChaveNfe;
                        if (verificaCliFor.Count > 0 &&  verificaCliFor[2] == "1")
                        {
                            logMsg = "CLIENTE/FORNECEDOR BLOQUEADO NO SISTEMA";
                        }

                        //Caso o cliente/fornecedor não exista no ERP, será criado um log
                        this.escreveLog("Arquivo " + nota.nomeArquivo + " criticado", logMsg);
                        

                        var query = "INSERT INTO CRITICAXML (CODFILIAL, NOME_XML, DATAEMISSAO, SETOR, CNPJ, RAZAO, CRITICA, TIPO, CNPJINTERNO, GRUPO) VALUES " +
                                        "('" + nota.CodFilErp + "', '" + nota.nomeArquivo.Replace(this.parametros.PastaProcessar, this.parametros.PastaCriticados) + "', '" + nota.DataEmissao + "', 'CMP', '" + nota.CnpjCliFor + "', " +
                                        "'" + nota.nomeCliFor + "', '"+ logMsg + "', 'C', '" + nota.cnpjInterno + "', '" + nota.CodEmpErp + "')";
                        var color = Console.ForegroundColor;
                        Console.ForegroundColor = System.ConsoleColor.Red;
                        Console.WriteLine(logMsg);
                        Console.ForegroundColor = color;

                        
                        this.dbInspetor.execQuery(query);
                        FuncoesErp.movePara(nota.nomeArquivo, parametros.PastaCriticados);
                        continue;
                    }
                    //Se o xml não estiver criticado, mas não existir condição de pagamento entra na crítica
                    if (nota.CodCondPagto == "" && !nota.xmlCriticado)
                    {
                        nota.xmlCriticado = true;
                        //Caso o cliente/fornecedor não possua forma de pagamento cadastrado
                        this.escreveLog("Arquivo " + nota.nomeArquivo + " criticado", "O CLIENTE/FORNECEDOR NAO POSSUI COND. DE PAGTO CADASTRADA NO SISTEMA");
                        this.dbInspetor.execQuery("INSERT INTO CRITICAXML (CODFILIAL, NOME_XML, DATAEMISSAO, SETOR, CNPJ, RAZAO, CRITICA, TIPO, CNPJINTERNO, GRUPO) VALUES " +
                                        "('" + nota.CodFilErp + "', '" + nota.nomeArquivo.Replace(this.parametros.PastaProcessar, this.parametros.PastaCriticados) + "', '" + nota.DataEmissao + "', 'CMP', '" + nota.CnpjCliFor + "', " +
                                        "'" + nota.nomeCliFor + "', 'O CLIENTE/FORNECEDOR NAO POSSUI COND. DE PAGTO CADASTRADA NO SISTEMA', 'C', '" + nota.cnpjInterno + "', '" + nota.CodEmpErp + "')");
                        continue;
                    }
                    
                }
                //Inicia o tratamento dos produtos
                
                StringBuilder inserts = new StringBuilder();
                foreach (var item in nota.Itens)
                {
                    inserts.Append(FuncoesErp.sqlInsereItem(this.parametros.TipoErp, nota.TipoNf, item, nota.CodEmpErp, nota.CodFilErp, nota.CodCliForErp, nota.NumNf, nota.DataEmissao, nota.serieNf, nota.CodLojaCliForErp));                    
                }

                var insertNota = FuncoesErp.sqlInsereCabecNf(this.parametros.TipoErp, nota);


                var parcela = 0;
                var insertFinanc = "";
                if (nota.TipoNf == "ENTRADA" || nota.TipoNf == "SAIDA")
                {
                    //Insere os lançamentos financeiros

                    TNfeProc notaSerializada;

                    XmlSerializer mySerializer = new XmlSerializer(typeof(TNfeProc));

                    FileStream myFileStream = new FileStream(nota.nomeArquivo, FileMode.Open);
                    var reader = XmlReader.Create(myFileStream);
                    notaSerializada = (TNfeProc)mySerializer.Deserialize(reader);
                    
                    try
                    {
                        var totalFinanceiro = 0.00;
                        foreach (var item in notaSerializada.NFe.infNFe.cobr.dup)
                        {
                            totalFinanceiro += Convert.ToDouble(item.vDup);
                            parcela++;

                            //Verifica se é a última parcela. Se a soma das parcelas financeiras for 
                            //menor que o valor da nota, será lançada a diferença
                            if (parcela == notaSerializada.NFe.infNFe.cobr.dup.Length && totalFinanceiro < Convert.ToDouble(nota.valorNf))
                            {
                                    totalFinanceiro = Convert.ToDouble(nota.valorNf) - totalFinanceiro;
                                    insertFinanc += " " + FuncoesErp.insereFinanceiro(nota, totalFinanceiro.ToString(), item.vDup, parcela.ToString());
                            }                            
                            else
                            {
                                insertFinanc += " " + FuncoesErp.insereFinanceiro(nota, item.dVenc, item.vDup, parcela.ToString());
                            }                                                        
                        }

                    }
                    catch (Exception)
                    {

                        parcela++;
                        insertFinanc = FuncoesErp.insereFinanceiro(nota, nota.DataEmissao, nota.ValorBruto, parcela.ToString());
                        

                    }
                    myFileStream.Close();
                }

                inserts.Append(insertNota);
                inserts.Append(insertFinanc);

                var insereSf3 = FuncoesErp.InsereSf3(nota);
                inserts.Append(insereSf3);


                //Inserts para a tabela SFT
                foreach (var item in nota.Itens)
                {                    
                    inserts.Append(FuncoesErp.InsereSft(nota, item));
                }

                if (nota.TipoNf == "SAIDA")
                {
                    var queryC5_Num = dbErp.queryListToDic("SELECT ISNULL(REPLICATE('0', 6 - LEN(MAX(C5_NUM) + 1)) + CAST(MAX(C5_NUM) + 1 AS VARCHAR(6)), '000001') AS C5_NUM FROM SC5" + nota.CodEmpErp + "0 WHERE C5_FILIAL = '" + nota.CodFilErp + "';");
                    if (queryC5_Num.Count > 0)
                    {
                        var C5_NUM = queryC5_Num[0]["C5_NUM"];
                        var insertPedido = FuncoesErp.sqlInserePedidoVenda(nota.tipoErp, nota, C5_NUM);
                        
                        inserts.Append(insertPedido);
                        foreach (var item in nota.Itens)
                        {
                            var insertItensPedido = FuncoesErp.sqlInsereItensPedidoVenda(nota, item, C5_NUM);
                            inserts.Append(insertItensPedido);
                        }

                        foreach (var item in nota.Itens)
                        {
                            var insertPedidoLibera = FuncoesErp.sqlInserePedidoLiberado(nota, item, C5_NUM);
                            inserts.Append(insertPedidoLibera);
                        }                        
                    }
                }
                
                //Move o arquivo para a pasta de processados
                if (this.dbErp.insere(inserts.ToString()))
                {
                    Console.ForegroundColor = System.ConsoleColor.Green;
                    Console.WriteLine(nota.nomeArquivo + " | XML Inserido com sucesso!");
                    Console.ForegroundColor = System.ConsoleColor.Gray;
                    FuncoesErp.movePara(nota.nomeArquivo, parametros.PastaProcessados);
                }
                else
                {                    
                    FuncoesErp.movePara(nota.nomeArquivo, parametros.PastaCriticados);
                }
                
                Console.Write("");
            }
        }
    }
}
 