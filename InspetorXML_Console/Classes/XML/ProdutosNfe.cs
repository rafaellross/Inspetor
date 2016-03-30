using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspetorXML_Console.Classes.XML
{
    class ProdutosNfe
    {
        public string numItem { get; set; }
        public string cProd { get; set; } = "";
        public string xProd { get; set; } = "";
        public string NCM { get; set; } = "";
        public string CFOP { get; set; } = "";
        public string uCom { get; set; } = "";
        public string qCom { get; set; } = "";
        public string vUnCom { get; set; } = "";
        public string vProd { get; set; } = "";
        public string uTrib { get; set; } = "";
        public string qTrib { get; set; } = "";
        public string vUnTrib { get; set; } = "";
        public string vFrete { get; internal set; } = "";
        public string vDesc { get; internal set; } = "";
        public string vOutro { get; internal set; } = "";
        public string vSeg { get; internal set; } = "";
        public string pIPI { get; internal set; } = "";
        public string vIPI { get; internal set; } = "";
        public string CST { get; internal set; } = "";
        public string CSTCofins { get; internal set; } = "";
        public string vBCCofins { get; internal set; } = "";
        public string pCOFINS { get; internal set; } = "";
        public string vCOFINS { get; internal set; } = "";
        public string codProdErp { get; internal set; }
        public string codFilialProdErp { get; internal set; }
        public string vICMS { get; internal set; }
        public string TES { get; set; }
        public string CompCfop { get; internal set; }
        public string PICM { get; internal set; } = "";
        public string TpProd { get; internal set; }
        public string BaseIcms { get; internal set; }
        public string BaseIpi { get; internal set; }
        public string BaseCofins { get; internal set; }
        public string BasePis { get; internal set; }
        public string ValorPis { get; internal set; }
        public string pPIS { get; internal set; }
        public string CstIcms { get; internal set; }
        public string AliqIcms { get; internal set; }
        public string ValIcms { get; internal set; }
        public string GrpTrib { get; set; }
        public double VPrecoPauta { get; internal set; } = 0;
        public double dFatorMva { get; internal set; } = 0;
        public double dVPrecoPauta { get; internal set; } = 0;
        public double dVAliqPauta { get; internal set; } = 0;
        public string dAliqMvaST { get; internal set; }
        public string dMvaST { get; internal set; }
        public string sCst { get; internal set; }
        public bool bSimST { get; internal set; }
        public bool bValMvaSt { get; internal set; }
        public bool bValBcSt { get; internal set; }
        public string bRedBC { get; internal set; }
        public string dAliqIcmsSt { get; internal set; }
        public bool bValComReducao { get; internal set; }
        public bool bValAliqIcms { get; internal set; }
        public double dBcCalc { get; internal set; }
    }
}
