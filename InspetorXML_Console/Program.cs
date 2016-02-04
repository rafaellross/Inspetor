using InspetorXML_Console.Classes;
using InspetorXML_Console.Classes.App;
using InspetorXML_Console.Classes.ERP.Generico;
using InspetorXML_Console.Classes.XML;
using System;

namespace InspetorXML_Console
{
    class Program
    {
        static void Main(string[] args)
        {
        
        //Instancia a classe dos parametros
        Parametros parametros = new Parametros();

            

            //Carrega os parâmetros do arquivo config
            parametros.carregaParametros();

            DB dbErp = new DB(parametros.DBErpServer, parametros.DBErp, parametros.UserDBErp, parametros.PasswdDBErp, parametros.PastaLog, parametros.TipoErp);
            DB dbInspetor = new DB(parametros.DBInspetorServer, parametros.DBInspetor, parametros.UserDBInspetor, parametros.PasswdDBInspetor, parametros.PastaLog, "InspetorXml");

            //Instancia a classe para manipulação dos arquivos XML
            ManipulaXml notas = new ManipulaXml(dbInspetor, dbErp);

            //Passa o caminho da pasta de processamento dos arquivos
            notas.caminhoProcessar = parametros.PastaProcessar;

            //Carrega os arquivos XML
            notas.carregaXml();
            
            Erp erp = new Erp();


        }
    }
}
