﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InspetorXML_Console.Classes.App;
using InspetorXML_Console.Classes.XML;
using System.Collections;
using System.Globalization;
using System.IO;

namespace InspetorXML_Console.Classes.ERP.Generico
{
    class Erp
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
        public bool verificaProcessado(string chaveNfe, string TabEmpresa = "")
        {
            int consulta;

            if (this.parametros.TipoErp.ToString().ToLower() == "protheus")
            {
                consulta = dbErp.execQuery("SELECT F2_CHVNFE FROM SF2" + TabEmpresa + "0 WHERE F2_CHVNFE = '" + chaveNfe + "'  AND D_E_L_E_T_ <> '*'").Count;
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
                bool xmlProcessado = this.verificaProcessado(nota.ChaveNfe.Substring(3, nota.ChaveNfe.Length - 3), nota.CodEmpErp);
                if (xmlProcessado || nota.xmlCriticado)
                {
                    Console.WriteLine("Parada");
                    nota.xmlCriticado = true;

                    if (xmlProcessado)
                    {
                        this.escreveLog("Arquivo " + nota.nomeArquivo + " criticado", "JA FOI LANCADO NO SISTEMA");
                        //Caso a nota já tenha sido lançada, será criado um log
                        this.dbErp.execQuery("INSERT INTO LOGEVENTOSXML (NOME_XML, DATAEMISSAO, SETOR, USUARIO, EVENTO, CRITICA) " +
                                              "VALUES ('" + nota.nomeArquivo + "',GETDATE(), 'FIS', '" + parametros.User + "', 'I', 'XML TRANSFERIDO PARA A PASTA CRITICADOS, O MESMO JA FOI LANCADO NO SISTEMA.')");
                    }
                    else
                    {
                        this.escreveLog("Arquivo " + nota.nomeArquivo + " criticado", nota.msgCritica);
                        this.dbErp.execQuery("INSERT INTO LOGEVENTOSXML (NOME_XML, DATAEMISSAO, SETOR, USUARIO, EVENTO, CRITICA) " +
                                              "VALUES ('" + nota.nomeArquivo + "',GETDATE(), 'FIS', '" + parametros.User + "', 'I', '" + nota.msgCritica + "')");
                    }
                    continue;
                }

                //Caso hajam críticas, move arquivo para a pasta de críticados

                if (nota.xmlCriticado)
                {
                    //Move o arquivo para a pasta de criticados
                    if (File.Exists(parametros.PastaCriticados + "\\" + System.IO.Path.GetFileName(nota.nomeArquivo)))
                    {
                        File.Delete(parametros.PastaCriticados + "\\" + System.IO.Path.GetFileName(nota.nomeArquivo));
                    }
                    File.Move(nota.nomeArquivo, parametros.PastaCriticados + "\\" + System.IO.Path.GetFileName(nota.nomeArquivo));
                    continue;
                }

                //Verifica o cliente/fornecedor 
                if (!nota.xmlCriticado)
                {
                    //Atribui o código e filial da empresa que está no ERP
                    var CodEmpErp = nota.CodEmpErp;
                    var CodFilErp = nota.CodFilErp;


                    List<string> verificaCliFor = new List<string>();
                    string sqlVerificaCliFor = FuncoesErp.sqlCliForErp(this.parametros.TipoErp, nota.TipoNf, nota.CnpjCliFor, nota.CodEmpErp);
                    verificaCliFor = this.dbErp.consultaErp(sqlVerificaCliFor);
                    if (verificaCliFor.Count > 0 && verificaCliFor[2] == "2")
                    {
                        nota.CodCliForErp = verificaCliFor[0];
                        nota.CodLojaCliForErp = verificaCliFor[1];
                        nota.CodCondPagto = verificaCliFor[3];
                    }
                    else
                    {
                        nota.xmlCriticado = true;
                        //2 = DESBLOQUEADO / 1 = BLOQUEADO
                        //Verifica se o Cli/For está bloqueado
                        string logMsg = "O CLIENTE/FORNECEDOR NÃO EXISTE NA BASE DE DADOS DO ERP";
                        if (verificaCliFor[2] == "1")
                        {
                            logMsg = "CLIENTE/FORNECEDOR BLOQUEADO NO SISTEMA";
                        }

                        //Caso o cliente/fornecedor não exista no ERP, será criado um log
                        this.escreveLog("Arquivo " + nota.nomeArquivo + " criticado", logMsg);
                        this.dbErp.execQuery("INSERT INTO LOGEVENTOSXML (NOME_XML, DATAEMISSAO, SETOR, USUARIO, EVENTO, CRITICA) " +
                                              "VALUES ('" + nota.nomeArquivo + "',GETDATE(), 'FIS', '" + parametros.User + "', 'I', '" + logMsg + "')");
                    }
                    //Se o xml não estiver criticado, mas não existir condição de pagamento entra na crítica
                    if (nota.CodCondPagto == "" && !nota.xmlCriticado)
                    {
                        nota.xmlCriticado = true;
                        //Caso o cliente/fornecedor não possua forma de pagamento cadastrado
                        this.escreveLog("Arquivo " + nota.nomeArquivo + " criticado", "O CLIENTE/FORNECEDOR NAO POSSUI COND. DE PAGTO CADASTRADA NO SISTEMA");
                        this.dbErp.execQuery("INSERT INTO CRITICAXML (CODFILIAL, NOME_XML, DATAEMISSAO, SETOR, CNPJ, RAZAO, CRITICA, TIPO) VALUES " +
                                        "('" + nota.CodFilErp + "', '" + nota.nomeArquivo + "', '" + nota.DataEmissao + "', 'CMP', '" + nota.CnpjEmitente + "', " +
                                        "'" + nota.NomeEmitente + "', 'O CLIENTE/FORNECEDOR NAO POSSUI COND. DE PAGTO CADASTRADA NO SISTEMA', 'C')");
                        continue;
                    }
                    
                }
                //Inicia o tratamento dos produtos
                foreach (var item in nota.Itens)
                {
                    var query = FuncoesErp.sqlInsereItem(this.parametros.TipoErp, nota.TipoNf, item, nota.CodEmpErp, nota.CodFilErp, nota.CodCliForErp, nota.NumNf, nota.DataEmissao, nota.serieNf, nota.CodLojaCliForErp);
                    this.dbErp.execQuery(query);
                }

            }
        }


    }
}
 