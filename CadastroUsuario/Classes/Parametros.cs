using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace InspetorXML_Console.Classes.App
{
    class Parametros
    {
        //Parâmetros do Banco de Dados do Inspetor XML
        public string DBInspetor { get; private set; }
        public string DBInspetorServer { get; private set; }
        public string UserDBInspetor { get; private set; }
        public string PasswdDBInspetor { get; private set; }

        //Parâmetros do Banco de Dados do ERP
        public string DBErp { get; private set; }
        public string DBErpServer { get; private set; }
        public string UserDBErp { get; private set; }
        public string PasswdDBErp { get; private set; }
        public string TipoErp { get; private set; }

        //Parâmetros Gerais da Aplicação
        public string PastaProcessar { get; private set; }
        public string PastaProcessados { get; private set; }
        public string PastaManual { get; private set; }
        public string PastaCriticados { get; private set; }
        public string PastaLog { get; private set; }
        public int TempoExecucao { get; set; }
        public string User { get; private set; }
        public string ativaLog { get; private set; }

        public void carregaParametros()
        {

            var parametros = ConfigurationManager.AppSettings;

            //Parâmetros do Banco de Dados do Inspetor XML
            this.DBInspetor = parametros["DBInspetor"];
            this.DBInspetorServer = parametros["DBInspetorServer"];
            this.UserDBInspetor = parametros["UserDBInspetor"];
            this.PasswdDBInspetor = parametros["PasswdDBInspetor"];

            //Parâmetros do Banco de Dados do ERP
            this.DBErp = parametros["DBErp"];
            this.DBErpServer = parametros["DBErpServer"];
            this.UserDBErp = parametros["UserDBErp"];
            this.PasswdDBErp = parametros["PasswdDBErp"];
            this.TipoErp = parametros["TipoErp"];

            //Parâmetros Gerais da Aplicação
            this.PastaProcessar = parametros["PastaProcessar"];
            this.PastaProcessados = parametros["PastaProcessados"];
            this.PastaManual = parametros["PastaManual"];
            this.PastaCriticados = parametros["PastaCriticados"];
            this.PastaLog = parametros["PastaLog"];
            this.TempoExecucao = Convert.ToInt32(parametros.Get("TempoExecucao"));
            this.User = parametros["User"];
            this.ativaLog = parametros["AtivaLog"];
        }
    }
}
