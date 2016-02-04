using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspetorXML_Console.Classes.XML
{
    class ProdutosNfe
    {
        public string cProd { get; set; } = "NULL";
        public string xProd { get; set; } = "NUL";
        public string NCM { get; set; } = "NULL";
        public string CFOP { get; set; } = "NULL";
        public string uCom { get; set; } = "NULL";
        public string qCom { get; set; } = "NULL";
        public string vUnCom { get; set; } = "NULL";
        public string vProd { get; set; } = "NULL";
        public string uTrib { get; set; } = "NULL";
        public string qTrib { get; set; } = "NULL";
        public string vUnTrib { get; set; } = "NULL";
        public string vFrete { get; internal set; } = "NULL";
        public string vDesc { get; internal set; } = "NULL";
        public string vOutro { get; internal set; } = "NULL";
        public string vSeg { get; internal set; } = "NULL";
        public string pIPI { get; internal set; } = "NULL";
        public string vIPI { get; internal set; } = "NULL";
        public string CST { get; internal set; } = "NULL";
        public string CSTCofins { get; internal set; } = "NULL";
        public string vBC { get; internal set; } = "NULL";
        public string pCOFINS { get; internal set; } = "NULL";
        public string vCOFINS { get; internal set; } = "NULL";
    }
}
