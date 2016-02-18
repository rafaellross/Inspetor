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

        public void inicia()
        {
            foreach (var nota in this.arquivosXml)
            {
                //Verifica se a nota já foi lançada
                var chave = nota.ChaveNfe.Substring(3, nota.ChaveNfe.Length - 3);
                if (!this.verificaProcessado(nota.ChaveNfe.Substring(3, nota.ChaveNfe.Length-3)))
                {

                    var CodEmpErp = nota.CodEmpErp;
                    var CodFilErp = nota.CodFilErp;
                       
                    //nota.CodEmpErp = CodEmpErp[0];
                    Console.Write("Nota lançada");
                }
                else
                {
                    //Caso a nota já tenha sido lançada, será criado um log
                    this.dbErp.execQuery("INSERT INTO LOGEVENTOSXML (NOME_XML, DATAEMISSAO, SETOR, USUARIO, EVENTO, CRITICA) " +
                                          "VALUES ('" + nota.nomeArquivo + "',GETDATE(), 'FIS', '" + parametros.User + "', 'I', 'XML TRANSFERIDO PARA A PASTA CRITICADOS, O MESMO JA FOI LANCADO NO SISTEMA.')");
                    //Move o arquivo para a pasta de criticados
                    if (File.Exists(parametros.PastaCriticados + "\\" + System.IO.Path.GetFileName(nota.nomeArquivo)))
                    {
                        File.Delete(parametros.PastaCriticados + "\\" + System.IO.Path.GetFileName(nota.nomeArquivo));                        
                    }
                    File.Move(nota.nomeArquivo, parametros.PastaCriticados + "\\" + System.IO.Path.GetFileName(nota.nomeArquivo));

                }
            }
        }

        //Esta função verifica se a nota já foi lançada no Erp e retorna true ou false
        public bool verificaProcessado(string chaveNfe, string TabEmpresa = "")
        {
            int consulta;

            if (this.parametros.TipoErp.ToLower() == "protheus")
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
                return false;
            }
            else
            {
                return true;
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
    }
}
 