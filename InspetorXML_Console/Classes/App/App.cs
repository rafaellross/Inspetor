using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspetorXML_Console.Classes.App
{
    class App : Parametros
    {
        public DB DBXml { get; set; }
        public DB BancoErp { get; set; }

        public App()
        {
            this.DBXml = new DB(this.DBInspetorServer, this.DBInspetor, this.UserDBInspetor, this.PasswdDBErp, this.PastaLog, "Inspetor");
            this.DBXml.abreConexao();
            this.BancoErp = new DB(this.DBErpServer, this.DBErp, this.UserDBErp, this.PasswdDBErp, this.PastaLog, "Erp");
            this.BancoErp.abreConexao();
        }
    }
}
