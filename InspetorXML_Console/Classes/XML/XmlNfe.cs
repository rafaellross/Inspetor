using InspetorXML_Console.Classes.ERP.Generico;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;

namespace InspetorXML_Console.Classes.XML
{
    class XmlNfe 
    {
        public string CnpjEmitente { get; set; }
        public string NomeEmitente { get; set; }
        public string UFEmitente { get; set; }
        public string CnpjDestinatario { get; set; }
        public string NomeDestinatario { get; set; }
        public string UFDestinatario { get; set; }
        public string TipoCli { get; set; }
        public string SC5Num { get; set; }
        public List<ProdutosNfe> Itens { get; set; }
        public string codTabProd { get; set; }

        private XmlNamespaceManager nameSpace { get; set; }
        public XPathNavigator xpathNav { get; set; }
        public string DataEmissao { get; private set; }
        public string CRT { get; private set; } = "";
        public string DataSaidaEntrada { get; private set; }
        public string ChaveNfe { get; private set; }
        public XmlDocument xml { get; private set; }
        public DB dbXml { get; set; }
        public DB dbErp { get; set; }
        public string TipoNf { get; set; }
        public string nomeArquivo { get; set; }
        public string NumNf { get; set; }
        public string serieNf { get; private set; }
        public string valorNf { get; private set; }
        public string vST { get; private set; }
        public string placaTransportadora { get; private set; }
        public string ufPlacaTransportadora { get; private set; }
        public string pesoL { get; private set; }
        public string pesoB { get; private set; }
        public string esp { get; private set; }
        public string dhSaiEnt { get; private set; }
        public string modFrete { get; private set; }
        public string CnpjTransportadora { get; private set; }
        public string qVol { get; private set; }
        public string marcaTransportadora { get; private set; }
        public string nomeTransportadora { get; private set; }
        public string ieTransportadora { get; private set; }
        public string enderecoTransportadora { get; private set; }
        public string municipioTransportadora { get; private set; }
        public string ufTransportadora { get; private set; }
        public string vICMS { get; private set; }
        public string nDI { get; private set; }
        public string dDI { get; private set; }
        public string xLocDesemb { get; private set; }
        public string UFDesemb { get; private set; }
        public string dDesemb { get; private set; }
        public string infCpl { get; private set; }
        public string infAdFisco { get; private set; }
        public string CodCliForErp { get; set; }
        public string CodEmpErp { get; set; }
        public string tipoErp { get; private set; }
        public string CodFilErp { get; private set; }
        public bool xmlCriticado { get; set; }
        public string msgCritica { get; set; }
        public string CnpjCliFor { get; internal set; }
        public string CodLojaCliForErp { get; internal set; }
        public string CodCondPagto { get; internal set; } = "";
        public string vFrete { get; internal set; }
        public string vOutro { get; internal set; }
        public string BaseIcms { get; internal set; }
        public string ValorIcms { get; internal set; }
        public string vIPI { get; private set; }
        public object ValorBruto { get; internal set; }
        public string vSeg { get; private set; }
        public string vDesc { get; private set; }

        public XmlNfe(string tipoErp, string nomeArquivo, string xmlInput, string nameSpace, DB dbXml, DB dbErp)
        {
            XmlDocument docXml = new XmlDocument();
            docXml.Load(xmlInput);

            try
            {
                this.xml = docXml;
                                
            }
            catch (System.Xml.XmlException ex)
            {
                this.xmlCriticado = true;
                this.msgCritica = ex.ToString();
            }
            
            this.Itens = new List<ProdutosNfe>();
            this.dbXml = dbXml;
            this.dbErp = dbErp;
            this.nomeArquivo = nomeArquivo;
            this.tipoErp = tipoErp;
        }

        //Este método carrega um arquivo Xml a partir do caminho do arquivo
        public XmlDocument lerXml(string arquivo)
        {
            XmlDocument DocXml = new XmlDocument();
            DocXml.Load(arquivo);
            return DocXml;
        }

        public void carregaAtributos()
        {
            if (!this.xmlCriticado)
            {
            
            nameSpace = new XmlNamespaceManager(xml.NameTable);
            nameSpace.AddNamespace("nfe", "http://www.portalfiscal.inf.br/nfe");
            this.xpathNav = xml.CreateNavigator();
            XPathNavigator node;

        //Carrega os dados do emitente
            //Atribui o Cnpj do Emitente

            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:emit/nfe:CNPJ", this.nameSpace);
            this.CnpjEmitente = node.InnerXml.ToString();

            //Caso não tenha CNPJ, será atribuído o CPF
            if (node.InnerXml.ToString() == String.Empty)
            {
                node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:emit/nfe:CPF", nameSpace);
                this.CnpjEmitente = node.InnerXml.ToString();
            }
            

            //Atribui a razão social do Emitente
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:emit/nfe:xNome", nameSpace);
            this.NomeEmitente = node.InnerXml.ToString(); //Razao Social do Fornecedor

            //Atribui o UF do Emitente
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:emit/nfe:enderEmit/nfe:UF", nameSpace);
            this.UFEmitente = node.InnerXml.ToString();

        //Carrega os dados do destinatário
            //Atribui o Cnpj do Destinatário
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:dest/nfe:CNPJ", nameSpace);
            this.CnpjDestinatario = node.InnerXml.ToString();

            //Caso não tenha CNPJ, será atribuído o CPF
            if (node == null)
            {
                node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:dest/nfe:CPF", nameSpace);
                this.CnpjDestinatario = node.InnerXml.ToString();
            }

            //Atribui a razão social do Destinatário
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:dest/nfe:xNome", nameSpace);
            this.NomeDestinatario = node.InnerXml.ToString();

            //Atribui UF do destinatário
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:dest/nfe:enderDest/nfe:UF", nameSpace);
            this.UFDestinatario = node.InnerXml.ToString();

        //Carrega os dados gerais da nota
            //Atribui a data de emissão
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:ide/nfe:dhEmi", nameSpace);
            string dhEmi = node.InnerXml.ToString();
            this.DataEmissao = dhEmi.Substring(0, 19);

            //Atribui a data de saída / entrada
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:ide/nfe:dhSaiEnt", nameSpace);
            string dhSaiEnt = node.InnerXml.ToString();
            this.DataSaidaEntrada = dhSaiEnt.Substring(0, 19);


            //Atribui CRT (Código de Regime Tributário)
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:emit/nfe:CRT", nameSpace);
            this.CRT = node.InnerXml.ToString();
                

            //Atribui a chave da Nfe
            node = xpathNav.SelectSingleNode("//nfe:infNFe", nameSpace);
            this.ChaveNfe = node.GetAttribute("Id", "");

            //Numero da Nf
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:ide/nfe:nNF", nameSpace);
            if (node != null)
            {
                this.NumNf = node.InnerXml.ToString();
            }

            //Serie da Nf
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:ide/nfe:serie", nameSpace);
            if (node != null)
            {
                this.serieNf = node.InnerXml.ToString();
            }

            //Valor da Nf
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:total/nfe:ICMSTot/nfe:vNF", nameSpace);
            if (node != null)
            {
                this.valorNf = node.InnerXml.ToString();
            }

            //Valor vICMS
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:total/nfe:ICMSTot/nfe:vICMS", nameSpace);
            if (node != null)
            {
                this.vICMS = node.InnerXml.ToString();
            }

            //vST
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:total/nfe:ICMSTot/nfe:vST", nameSpace);
            if (node != null)
            {
                this.vST = node.InnerXml.ToString();
            }
            //Outros valores
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:total/nfe:ICMSTot/nfe:vOutro", nameSpace);
            if (node != null)
            {
                this.vOutro = node.InnerXml.ToString();
            }

            //Valor do IPI
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:total/nfe:ICMSTot/nfe:vIPI", nameSpace);
            if (node != null)
            {
                this.vIPI = node.InnerXml.ToString();
            }

            //Valor Bruto
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:total/nfe:ICMSTot/nfe:vProd", nameSpace);
            if (node != null)
            {
                this.ValorBruto = node.InnerXml.ToString();
            }

            //vSeg
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:total/nfe:ICMSTot/nfe:vSeg", nameSpace);
            if (node != null)
            {
                this.vSeg = node.InnerXml.ToString();
            }

            //vDesc
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:total/nfe:ICMSTot/nfe:vDesc", nameSpace);
            if (node != null)
            {
                this.vDesc = node.InnerXml.ToString();
            }

                //Dados da transportadora

                //Placa da Transportadora
                node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:transp/nfe:veicTransp/nfe:placa", nameSpace);
            if (node != null)
            {
                this.placaTransportadora = node.InnerXml.ToString();
            }

            //UF Placa da Transportadora
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:transp/nfe:veicTransp/nfe:UF", nameSpace);
            if (node != null)
            {
                this.ufPlacaTransportadora = node.InnerXml.ToString();
            }

            //Peso liquido
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:transp/nfe:vol/nfe:pesoL", nameSpace);
            if (node != null)
            {
                this.pesoL = node.InnerXml.ToString();
            }

            //Peso bruto
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:transp/nfe:vol/nfe:pesoB", nameSpace);
            if (node != null)
            {
                this.pesoB = node.InnerXml.ToString();
            }

            //Especie
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:transp/nfe:vol/nfe:esp", nameSpace);
            if (node != null)
            {
                this.esp = node.InnerXml.ToString();
            }

            //modFrete
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:transp/nfe:modFrete", nameSpace);
            if (node != null)
            {
                this.modFrete = node.InnerXml.ToString();
            }

            //Cnpj da Transportadora
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:transp/nfe:transporta/nfe:CNPJ", nameSpace);
            if (node != null)
            {
                this.CnpjTransportadora = node.InnerXml.ToString();
            }

            //qVol
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:transp/nfe:vol/nfe:qVol", nameSpace);
            if (node != null)
            {
                this.qVol = node.InnerXml.ToString();
            }

            //Marca transportadora
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:transp/nfe:vol/nfe:marca", nameSpace);
            if (node != null)
            {
                this.marcaTransportadora = node.InnerXml.ToString();
            }

            //Nome da Transportadora
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:transp/nfe:transporta/nfe:xNome", nameSpace);
            if (node != null)
            {
                this.nomeTransportadora = node.InnerXml.ToString();
            }

            //Inscrição Estadual Transportadora
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:transp/nfe:transporta/nfe:IE", nameSpace);
            if (node != null)
            {
                this.ieTransportadora = node.InnerXml.ToString();
            }

            //Endereço Transportadora
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:transp/nfe:transporta/nfe:xEnder", nameSpace);
            if (node != null)
            {
                this.enderecoTransportadora = node.InnerXml.ToString();
            }

            //Município Transportadora
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:transp/nfe:transporta/nfe:xMun", nameSpace);
            if (node != null)
            {
                this.municipioTransportadora = node.InnerXml.ToString();
            }

            //UF Transportadora
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:transp/nfe:transporta/nfe:UF", nameSpace);
            if (node != null)
            {
                this.ufTransportadora = node.InnerXml.ToString();
            }

            //Valor ICMS
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:total/nfe:ICMSTot/nfe:vICMS", nameSpace);

            if (node != null)
            {
                this.vICMS = node.InnerXml.ToString();
            }

            //nDI
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[1]/nfe:prod/nfe:DI/nfe:nDI", nameSpace);
            if (node != null)
            {
                this.nDI = node.InnerXml.ToString();
            }

            //dDI
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[1]/nfe:prod/nfe:DI/nfe:dDI", nameSpace);
            if (node != null)
            {
                this.dDI = node.InnerXml.ToString();
            }

            //LocDesemb
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[1]/nfe:prod/nfe:DI/nfe:xLocDesemb", nameSpace);
            if (node != null)
            {
                this.xLocDesemb = node.InnerXml.ToString();
            }

            //UF Desemb
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[1]/nfe:prod/nfe:DI/nfe:UFDesemb", nameSpace);
            if (node != null)
            {
                this.UFDesemb = node.InnerXml.ToString();
            }

            //dDesemb
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[1]/nfe:prod/nfe:DI/nfe:dDesemb", nameSpace);
            if (node != null)
            {
                this.dDesemb = node.InnerXml.ToString();
            }

            //infCpl
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:infAdic/nfe:infCpl", nameSpace);
            if (node != null)
            {
                this.infCpl = node.InnerXml.ToString();
            }

            //infAdFisco
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:infAdic/nfe:infAdFisco", nameSpace);
            if (node != null)
            {
                this.infAdFisco = node.InnerXml.ToString();
            }

            //Leitura dos produtos da Nfe
            int i = 1;
            bool ultimo = false;
            while (!ultimo)
            {
                node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:prod/nfe:xProd", nameSpace);
                if (node == null)
                {
                    ultimo = true;
                }
                else
                {
                    ProdutosNfe produto = new ProdutosNfe();
                    produto.numItem = i.ToString();
                    produto.xProd = node.InnerXml.ToString();

                    //Atribui o CFOP
                    node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:prod/nfe:CFOP", nameSpace);

                    if (node != null)
                    {
                        produto.CFOP = node.InnerXml.ToString();
                    }

                    //Atribui o cProd
                    node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:prod/nfe:cProd", nameSpace);

                    if (node != null)
                    {
                        produto.cProd = node.InnerXml.ToString();
                    }

                    //Atribui o NCM
                    node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:prod/nfe:NCM", nameSpace);
                    if (node != null)
                    {
                        produto.NCM = node.InnerXml.ToString();
                    }

                        //Atribui qCom
                        node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:prod/nfe:qCom", nameSpace);
                    if (node != null)
                    {
                        produto.qCom = node.InnerXml.ToString();
                    }

                    //Atribui uCom
                    node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:prod/nfe:uCom", nameSpace);
                    if (node != null)
                    {
                        produto.uCom = node.InnerXml.ToString();
                    }

                    //Atribui vProd
                    node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:prod/nfe:vProd", nameSpace);
                    if (node != null)
                    {
                        produto.vProd = node.InnerXml.ToString();
                    }

                    //Atribui vUnCom
                    node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:prod/nfe:vUnCom", nameSpace);
                    if (node != null)
                    {
                        produto.vUnCom = node.InnerXml.ToString();
                    }

                    //Atribui vFrete
                    node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:prod/nfe:vFrete", nameSpace);
                    if (node != null)
                    {
                        produto.vFrete = node.InnerXml.ToString();
                    }

                    //Atribui vDesc
                    node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:prod/nfe:vDesc", nameSpace);
                    if (node != null)
                    {
                        produto.vDesc = node.InnerXml.ToString();
                    }

                    //Atribui vOutro
                    node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:prod/nfe:vOutro", nameSpace);
                    if (node != null)
                    {
                        produto.vOutro = node.InnerXml.ToString();
                    }

                    //vSeg
                    node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:prod/nfe:vSeg", nameSpace);
                    if (node != null)
                    {
                        produto.vSeg = node.InnerXml.ToString();
                    }

                    //pIPI
                    node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:IPI/nfe:IPITrib/nfe:pIPI", nameSpace);
                    if (node != null)
                    {
                        produto.pIPI = node.InnerXml.ToString();
                    }
                    
                    //vIPI
                    node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:IPI/nfe:IPITrib/nfe:vIPI", nameSpace);
                    if (node != null)
                    {
                        produto.vIPI = node.InnerXml.ToString();
                    }

                    //ICMS
                    // node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:ICMS/nfe:ICMS" + sIcms + "/nfe:pICMS", nameSpace);
                        


                    //CST
                        node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:COFINS/nfe:COFINSAliq/nfe:CST", nameSpace);
                    if (node != null)
                    {
                        produto.CST = node.InnerXml.ToString();
                    }

                    //Verifica se há CSTCofins
                    node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:COFINS/nfe:COFINSAliq/nfe:CST", nameSpace);
                    if (node != null)
                    {
                        produto.CSTCofins = node.InnerXml.ToString();

                        //Atribui vBC
                        node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:COFINS/nfe:COFINSAliq/nfe:vBC", nameSpace);
                        if (node != null)
                        {
                            produto.vBC = node.InnerXml.ToString();
                        }

                        //Atribui pCOFINS
                        node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:COFINS/nfe:COFINSAliq/nfe:pCOFINS", nameSpace);
                        if (node != null)
                        {
                            produto.pCOFINS = node.InnerXml.ToString();
                        }

                        //vCOFINS
                        node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:COFINS/nfe:COFINSAliq/nfe:vCOFINS", nameSpace);
                        if (node != null)
                        {
                            produto.vCOFINS = node.InnerXml.ToString();
                        }
                    }
                    else
                    {
                        node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:COFINS/nfe:COFINSNT/nfe:CST", nameSpace);
                        if (node != null)
                        {
                            produto.CSTCofins = node.InnerXml.ToString();
                            
                        }
                    }

                    node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:COFINS/nfe:COFINSNT/nfe:CST", nameSpace);
                    if (node != null)
                    {
                        this.CRT = node.InnerXml.ToString();

                    }

                    //Base de Cofins
                    node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:COFINS/nfe:COFINSAliq/nfe:vBC", nameSpace);
                    if (node != null)
                    {
                       produto.BaseCofins = node.InnerXml.ToString();
                    }

                    //Base de Pis
                    node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:PIS/nfe:PISAliq/nfe:vBC", nameSpace);
                    if (node != null)
                    {
                        produto.BasePis = node.InnerXml.ToString();
                    }


                    //Valor do Pis
                    node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:PIS/nfe:PISAliq/nfe:vPIS", nameSpace);
                    if (node != null)
                    {
                        produto.ValorPis = node.InnerXml.ToString();
                    }

                    //Percentual/Aliquota do Pis
                    node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:PIS/nfe:PISAliq/nfe:pPIS", nameSpace);
                    if (node != null)
                    {
                        produto.pPIS = node.InnerXml.ToString();
                    }


                    List<string> verificaEmpresa = new List<string>();

                    string sqlVerificaEmpresa;


                    if (this.dbErp.tipoDB.ToLower() == "protheus")
                    {
                        sqlVerificaEmpresa = "SELECT M0_CODIGO, M0_CODFIL FROM SIGAMAT WHERE M0_CGC = '" + this.CnpjEmitente + "'";
                    }
                    else
                    {
                        //Implementar a query do RM aqui
                        sqlVerificaEmpresa = "SELECT CODCOLIGADA, CODFILIAL FROM GFILIAL WHERE REPLACE(REPLACE(REPLACE(CGC, '.', ''), '/', ''), '-', '') = '" + this.CnpjEmitente+"'";
                    }
                    
                    verificaEmpresa = this.dbXml.consultaErp(sqlVerificaEmpresa);
                    //Se o emitente estiver na sigamat então o tipo da nota será saída
                    if (verificaEmpresa.Count > 0)
                    {
                        this.CnpjCliFor = this.CnpjDestinatario;
                        this.TipoNf = "SAIDA";
                    }
                    else
                    {
                        this.CnpjCliFor = this.CnpjEmitente;
                        this.TipoNf = "ENTRADA";
                    }

                    this.carregaDadosErp();
                    //Carrega o código do produto do ERP
                    string query = FuncoesErp.sqlCodProdErp(this.tipoErp, produto.NCM, this.codTabProd, this.CodFilErp);
                    var lista = this.dbErp.consultaErp(query);
                    try
                    {
                        produto.codProdErp = lista[0];
                        produto.codFilialProdErp = lista[1];
                        produto.TpProd = lista[2];
                    }
                    catch (Exception ex)
                    {
                        this.xmlCriticado = true;
                        this.msgCritica = "Produto não cadastrado! " + ex.ToString();
                    }

                    //Atribui o campo TES                    
                    query = FuncoesErp.sqlTES(this.tipoErp, produto.codProdErp, produto.codFilialProdErp, this.CodEmpErp, this.TipoNf, this.codTabProd);
                    lista = this.dbErp.consultaErp(query);
                    try
                    {                            
                        produto.CompCfop = lista[0];
                        produto.TES = lista[1];                        
                    }
                    catch (Exception ex)
                    {
                        this.xmlCriticado = true;
                        this.msgCritica = ex.ToString();
                    }

                    this.Itens.Add(produto);
                    i++;                    
                }

            }
        }
        } //Fim da função

        public void carregaDadosErp()
        {
            string query = FuncoesErp.sqlEmpresaErp(this.tipoErp, this.TipoNf == "ENTRADA" ? this.CnpjDestinatario : this.CnpjEmitente);
            var lista = this.dbXml.consultaErp(query);
            try
            {
                this.CodEmpErp = lista[0];
                this.CodFilErp = lista[1];
            }
            catch (Exception ex)
            {
                this.xmlCriticado = true;
                this.msgCritica = ex.ToString();
            }

            //Query para pegar a tabela dos produtos do ERP
            query = FuncoesErp.sqlTabProdErp(this.tipoErp, this.CodEmpErp);
            lista = this.dbXml.consultaErp(query);
            try
            {
                this.codTabProd = lista[1];
            }
            catch (Exception ex)
            {
                this.xmlCriticado = true;
                this.msgCritica = ex.ToString();
            }            
        }

        public string PegaIcmsSn(XmlDocument xmlDoc, int item)
        {
            var ns = new XmlNamespaceManager(xmlDoc.NameTable);
            ns.AddNamespace("nfe", "http://www.portalfiscal.inf.br/nfe");
            XPathNavigator xpathNav = xmlDoc.CreateNavigator();
            XPathNavigator node101;
            XPathNavigator node102;
            XPathNavigator node103;
            XPathNavigator node201;
            XPathNavigator node202;
            XPathNavigator node203;
            XPathNavigator node300;
            XPathNavigator node400;
            XPathNavigator node500;
            XPathNavigator node900;
            string sResp = "";

            node101 = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + item + "]/nfe:imposto/nfe:ICMS/nfe:ICMSSN101/nfe:orig", ns);
            node102 = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + item + "]/nfe:imposto/nfe:ICMS/nfe:ICMSSN102/nfe:orig", ns);
            node103 = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + item + "]/nfe:imposto/nfe:ICMS/nfe:ICMSSN103/nfe:orig", ns);
            node201 = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + item + "]/nfe:imposto/nfe:ICMS/nfe:ICMSSN201/nfe:orig", ns);
            node202 = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + item + "]/nfe:imposto/nfe:ICMS/nfe:ICMSSN202/nfe:orig", ns);
            node203 = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + item + "]/nfe:imposto/nfe:ICMS/nfe:ICMSSN203/nfe:orig", ns);
            node300 = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + item + "]/nfe:imposto/nfe:ICMS/nfe:ICMSSN300/nfe:orig", ns);
            node400 = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + item + "]/nfe:imposto/nfe:ICMS/nfe:ICMSSN400/nfe:orig", ns);
            node500 = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + item + "]/nfe:imposto/nfe:ICMS/nfe:ICMSSN500/nfe:orig", ns);
            node900 = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + item + "]/nfe:imposto/nfe:ICMS/nfe:ICMSSN900/nfe:orig", ns);

            if (node101 != null)
            {
                sResp = "101";
            }
            else if (node101 != null)
            {
                sResp = sResp.Trim() == "" ? "101" : sResp + ";101";
                
            }
            else if (node102 != null)
            {
                sResp = sResp.Trim() == "" ? "102" : sResp + ";102";
            }
            else if (node103 != null)
            {
                sResp = sResp.Trim() == "" ? "103" : sResp + ";103";
            }
            else if (node201 != null)
            {
                sResp = sResp.Trim() == "" ? "201" : sResp + ";201";
            }
            else if (node202 != null)
            {
                sResp = sResp.Trim() == "" ? "202" : sResp + ";202";
            }
            else if (node203 != null)
            {
                sResp = sResp.Trim() == "" ? "203" : sResp + ";203";
            }
            else if (node300 != null)
            {
                sResp = sResp.Trim() == "" ? "300" : sResp + ";300";
            }
            else if (node400 != null)
            {
                sResp = sResp.Trim() == "" ? "400" : sResp + ";400";
            }
            else if (node500 != null)
            {
                sResp = sResp.Trim() == "" ? "500" : sResp + ";500";
            }
            else if (node900 != null)
            {
                sResp = sResp.Trim() == "" ? "900" : sResp + ";900";
            }

            return sResp;
        }

        public string PegaIcms(XmlDocument xmlDoc, int item)
        {
            var ns = new XmlNamespaceManager(xmlDoc.NameTable);
            ns.AddNamespace("nfe", "http://www.portalfiscal.inf.br/nfe");
            XPathNavigator xpathNav = xmlDoc.CreateNavigator();
            XPathNavigator node00;
            XPathNavigator node10;
            XPathNavigator node20;
            XPathNavigator node30;
            XPathNavigator node40;
            XPathNavigator node41;
            XPathNavigator node50;
            XPathNavigator node51;
            XPathNavigator node60;
            XPathNavigator node70;
            XPathNavigator node90;
            string sResp = "";

            node00 = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + item + "]/nfe:imposto/nfe:ICMS/nfe:ICMS00/nfe:orig", ns);
            node10 = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + item + "]/nfe:imposto/nfe:ICMS/nfe:ICMS10/nfe:orig", ns);
            node20 = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + item + "]/nfe:imposto/nfe:ICMS/nfe:ICMS20/nfe:orig", ns);
            node30 = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + item + "]/nfe:imposto/nfe:ICMS/nfe:ICMS30/nfe:orig", ns);
            node40 = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + item + "]/nfe:imposto/nfe:ICMS/nfe:ICMS40/nfe:orig", ns);
            node41 = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + item + "]/nfe:imposto/nfe:ICMS/nfe:ICMS41/nfe:orig", ns);
            node50 = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + item + "]/nfe:imposto/nfe:ICMS/nfe:ICMS50/nfe:orig", ns);
            node51 = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + item + "]/nfe:imposto/nfe:ICMS/nfe:ICMS51/nfe:orig", ns);
            node60 = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + item + "]/nfe:imposto/nfe:ICMS/nfe:ICMS60/nfe:orig", ns);
            node70 = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + item + "]/nfe:imposto/nfe:ICMS/nfe:ICMS70/nfe:orig", ns);
            node90 = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + item + "]/nfe:imposto/nfe:ICMS/nfe:ICMS90/nfe:orig", ns);

            if (node00 != null)
            {
                sResp = "00";
            }
            else if (node10 != null)
            {
                sResp = sResp.Trim() == "" ? "10" : sResp + ";10";
            }
            else if (node20 != null)
            {
                sResp = sResp.Trim() == "" ? "20" : sResp + ";20";
            }
            else if (node30 != null)
            {
                sResp = sResp.Trim() == "" ? "30" : sResp + ";30";
            }
            else if (node40 != null)
            {
                sResp = sResp.Trim() == "" ? "40" : sResp + ";40";
            }
            else if (node41 != null)
            {
                sResp = sResp.Trim() == "" ? "41" : sResp + ";41";
            }
            else if (node50 != null)
            {
                sResp = sResp.Trim() == "" ? "50" : sResp + ";50";
            }
            else if (node51 != null)
            {
                sResp = sResp.Trim() == "" ? "51" : sResp + ";51";
            }
            else if (node60 != null)
            {
                sResp = sResp.Trim() == "" ? "60" : sResp + ";60";
            }
            else if (node70 != null)
            {
                sResp = sResp.Trim() == "" ? "70" : sResp + ";70";
            }
            else if (node90 != null)
            {
                sResp = sResp.Trim() == "" ? "90" : sResp + ";90";
            }
            return sResp;
        }
    }
}
