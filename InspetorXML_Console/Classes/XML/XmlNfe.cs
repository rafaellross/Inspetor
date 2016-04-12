using InspetorXML_Console.Classes.App;
using InspetorXML_Console.Classes.ERP.Generico;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace InspetorXML_Console.Classes.XML
{
    class XmlNfe 
    {
        public string CnpjEmitente { get; set; }
        public string NomeEmitente { get; set; }
        public string UFEmitente { get; set; }
        public string CnpjDestinatario { get; set; } = "";
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
        public string ValorBruto { get; internal set; }
        public string vSeg { get; private set; }
        public string vDesc { get; private set; }
        public string EspNf { get; private set; }
        public double vBCCofins { get; private set; } = 0;
        public double BasePis { get; private set; } = 0;
        public double vCOFINS { get; private set; } = 0;
        public double ValorPis { get; private set; } = 0;
        public string CodTipoCliFor { get; internal set; }
        public string dBc { get; private set; }
        public string bAliqRedBCIcms { get; private set; }
        public string bAliqRedBCSTIcms { get; private set; }
        public string dAliqMvaST { get; private set; }
        public string dValBcSTIcms { get; private set; }
        public string dValIcmsSt { get; private set; }
        public string dAliqIcmsSt { get; private set; }
        public string sOrigCST { get; private set; }
        public string sCstIcms { get; private set; }
        public string dAliqIcms { get; private set; }
        public string dValIcms { get; private set; }
        public string dValBcIcms { get; private set; }        
        public Parametros parametros;
        public String[] matriz { get; set; }
        public String[] matrizComRed { get; set; }
        public String[] matrizAliqIcms { get; set; }
        public String[] matrizRevenda { get; set; }
        public String[] matrizUsoConsu { get; set; }
        public String[] matrizAtivo { get; set; }
        public object sCstRegra { get; private set; }
        public string sCstComReducao { get; private set; }
        public string sCstComAliqIcms { get; private set; }

        public string TabSA1 { get; set; }
        public string TabSA2 { get; set; }
        public string TabSF4 { get; set; }
        public string TabSB1 { get; set; }
        public string TabSD1 { get; set; }
        public string TabSD2 { get; set; }
        public string TabSF1 { get; set; }
        public string TabSA4 { get; set; }
        public string TabSC5 { get; set; }
        public string TabSC6 { get; set; }
        public string TabSC9 { get; set; }
        public string TabSF7 { get; set; }
        public string recnoNf { get; set; }
        public string TabSF2 { get; internal set; }
        public string nDup { get; private set; }
        public string TipoPessoa { get; private set; }
        public string enderecoDestinatario { get; private set; }
        public string codMunicipioDestinatario { get; private set; }
        public string nomeMunicipioDestinatario { get; private set; }
        public string bairroDestinatario { get; private set; }
        public string cepDestinatario { get; private set; }
        public string telefoneDestinatario { get; private set; }
        public string ieDestinatario { get; private set; } = "";
        public string enderecoEmitente { get; private set; }
        public string nroEnderecoEmitente { get; private set; }
        public string bairroEnderecoEmitente { get; private set; }
        public string codMunicipioEmitente { get; private set; }
        public string municipioEmitente { get; private set; }
        public string cepEmitente { get; private set; }
        public string telefoneEmitente { get; private set; }
        public string ieEmitente { get; private set; }
        public string inscMunicipalEmitente { get; private set; }
        public string paisDestinatario { get; private set; }
        public bool Exportacao { get; private set; }
        public string nomeCliFor { get; private set; }

        public XmlNfe(string tipoErp, string nomeArquivo, string xmlInput, string nameSpace, DB dbXml, DB dbErp, Parametros parametros)
        {
            XmlDocument docXml = new XmlDocument();
            try
            {
                docXml.Load(xmlInput);

                if (docXml.DocumentElement.Name != "nfeProc")
                {
                    this.xmlCriticado = true;
                    this.msgCritica = "Este XML não é de Nfe";

                }

            }
            catch (Exception ex)
            {
               this.xmlCriticado = true;
               this.msgCritica = "XML INVÁLIDO!";                                
            }


            this.parametros = parametros;
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

            
            var regrasCst = this.dbXml.queryListToDic(FuncoesErp.sqlRegrasCst());

            foreach (var regra in regrasCst)
            {
                switch (regra["ORDEM"].ToString())
                {
                    case "1":
                        this.sCstRegra = regra["CONTEUDO"];
                        break;

                    case "2":
                        this.sCstComReducao = regra["CONTEUDO"];
                        break;

                    case "3":
                        this.sCstComAliqIcms = regra["CONTEUDO"];
                        break;

                    default:
                        break;
                }
            }
            
            matriz = sCstRegra.ToString().Split(',');
            matrizComRed = sCstComReducao.ToString().Split(',');
            matrizAliqIcms = sCstComAliqIcms.ToString().Split(',');
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
            if (node != null)
            {
                this.CnpjEmitente = node.InnerXml.ToString();
                node = null;             
            }


            //Caso não tenha CNPJ, será atribuído o CPF
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:emit/nfe:CPF", nameSpace);
            

            if (node != null)
            {                
              this.CnpjEmitente = node.InnerXml.ToString();
            }
            

            //Atribui a razão social do Emitente
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:emit/nfe:xNome", nameSpace);
            if (node != null)
            {
                this.NomeEmitente = node.InnerXml.ToString().Replace("'", " "); //Razao Social do Fornecedor
            }
                 
            //Atribui o UF do Emitente
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:emit/nfe:enderEmit/nfe:UF", nameSpace);
            if (node != null)
            {
                this.UFEmitente = node.InnerXml.ToString();
            }

            //Atribui o Endereço do Emitente
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:emit/nfe:enderEmit/nfe:xLgr", nameSpace);
            if (node != null)
            {
                this.enderecoEmitente = node.InnerXml.ToString();
            }

            //Atribui o número do Endereço do Emitente
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:emit/nfe:enderEmit/nfe:nro", nameSpace);
            if (node != null)
            {
                this.nroEnderecoEmitente = node.InnerXml.ToString();
            }

            //Atribui o bairro do Endereço do Emitente
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:emit/nfe:enderEmit/nfe:xBairro", nameSpace);
            if (node != null)
            {
                this.bairroEnderecoEmitente = node.InnerXml.ToString();
            }

            //Atribui o codigo município do Emitente
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:emit/nfe:enderEmit/nfe:cMun", nameSpace);
            if (node != null)
            {
                this.codMunicipioEmitente = node.InnerXml.ToString();
            }


            //Atribui o nome do município do Emitente
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:emit/nfe:enderEmit/nfe:xMun", nameSpace);
            if (node != null)
            {
                this.municipioEmitente = node.InnerXml.ToString().Replace("'", " ");
            }

            //Atribui o CEP do Emitente
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:emit/nfe:enderEmit/nfe:CEP", nameSpace);
            if (node != null)
            {
                this.cepEmitente = node.InnerXml.ToString();
            }

            //Atribui o telefone do Emitente
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:emit/nfe:enderEmit/nfe:fone", nameSpace);
            if (node != null)
            {
                this.telefoneEmitente = node.InnerXml.ToString();
            }

            //Atribui o Insc. Estadual do Emitente
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:emit/nfe:IE", nameSpace);
            if (node != null)
            {
                this.ieEmitente = node.InnerXml.ToString();
            }

            //Atribui o Insc. Municipal do Emitente
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:emit/nfe:IM", nameSpace);
            if (node != null)
            {
                this.inscMunicipalEmitente = node.InnerXml.ToString();
            }


                //Carrega os dados do destinatário
                //Atribui o tipo de Pessoa (Física: 9 | Jurídica: Outros)
                node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:dest/nfe:indIEDest", nameSpace);
            if (node != null)
            {
                if (node.InnerXml.ToString() == "9")
                {
                    this.TipoPessoa = "F";
                }
                else
                {
                    this.TipoPessoa = "J";
                }
                
            }

            //Atribui o endereço do destinatário
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:dest/nfe:enderDest/nfe:xLgr", nameSpace);
            if (node != null)
            {
                this.enderecoDestinatario = node.InnerXml.ToString();
            }

                //Atribui o Cnpj do Destinatário
            //Verifica se o destinatário é estrangeiro
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:dest/nfe:idEstrangeiro", nameSpace);
            if (node == null)
            {
                    node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:dest/nfe:CNPJ", nameSpace);
                    if (node != null)
                    {
                        this.CnpjDestinatario = node.InnerXml.ToString();
                    }
                    else
                    {
                        node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:dest/nfe:CPF", nameSpace);
                        this.CnpjDestinatario = node.InnerXml.ToString();
                    }

                }
                else
                {
                    this.CnpjDestinatario = "0000000000000";
                }

           //Atribui a razão social do Destinatário
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:dest/nfe:xNome", nameSpace);
            if (node != null)
            {
                this.NomeDestinatario = node.InnerXml.ToString().Replace("'", " ");
            }
            

            //Atribui UF do destinatário
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:dest/nfe:enderDest/nfe:UF", nameSpace);
            if (node != null)
            {
                this.UFDestinatario = node.InnerXml.ToString();
            }

            //Atribui UF do destinatário
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:dest/nfe:enderDest/nfe:cPais", nameSpace);
            if (node != null)
            {
                this.paisDestinatario = node.InnerXml.ToString();
            }

            //Atribui Cod. Município do destinatário
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:dest/nfe:enderDest/nfe:cMun", nameSpace);
            if (node != null)
            {
                this.codMunicipioDestinatario = node.InnerXml.ToString();
            }

            //Atribui Nome Município do destinatário
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:dest/nfe:enderDest/nfe:xMun", nameSpace);
            if (node != null)
            {
                this.nomeMunicipioDestinatario = node.InnerXml.ToString().Replace("'", " ");
            }

            //Atribui Bairro do destinatário
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:dest/nfe:enderDest/nfe:xBairro", nameSpace);
            if (node != null)
            {
                this.bairroDestinatario = node.InnerXml.ToString();
            }

            //Atribui CEP do destinatário
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:dest/nfe:enderDest/nfe:CEP", nameSpace);
            if (node != null)
            {
                this.cepDestinatario = node.InnerXml.ToString();
            }

            //Atribui Telefone do destinatário
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:dest/nfe:enderDest/nfe:fone", nameSpace);
            if (node != null)
            {
                this.telefoneDestinatario = node.InnerXml.ToString();
            }

            //Atribui Insc. Estadual do destinatário
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:dest/nfe:enderDest/nfe:IE", nameSpace);
            if (node != null)
            {
                this.ieDestinatario = node.InnerXml.ToString();
            }

            //Carrega os dados gerais da nota
            //Atribui a data de emissão
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:ide/nfe:dhEmi", nameSpace);
            if (node != null)
            {
                string dhEmi = node.InnerXml.ToString();
                this.DataEmissao = dhEmi.Substring(0, 19);
                node = null;
           }

            //Atribui a data de saída / entrada
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:ide/nfe:dhSaiEnt", nameSpace);
                
            if (node != null)
            {
                string dhSaiEnt = node.InnerXml.ToString();
                this.DataSaidaEntrada = dhSaiEnt.Substring(0, 19);
            }


            //Atribui CRT (Código de Regime Tributário)
            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:emit/nfe:CRT", nameSpace);
            if (node != null)
            {
                this.CRT = node.InnerXml.ToString();
            }                

            //Atribui a chave da Nfe
            node = xpathNav.SelectSingleNode("//nfe:infNFe", nameSpace);
            if (node != null)
            {
                this.ChaveNfe = node.GetAttribute("Id", "").Substring(3, node.GetAttribute("Id", "").Length - 3);
            }                
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
                node = null;
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
                this.municipioTransportadora = node.InnerXml.ToString().Replace("'", " ");
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

            //EspNF - Especie NF
            if (this.TipoNf == "TRANSF_ENT" || this.TipoNf == "ENTRADA" || this.TipoNf == "ENT_IMP")
            {
                this.EspNf = "NFE";
            }
            else
            {
                this.EspNf = "NF";
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
                    //Icms Simples Nacional

                    if (this.CRT.ToString() == "1")
                                        {
                        var sIcms = PegaIcmsSn(xml, 1);
                        node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:ICMS/nfe:ICMSSN" + sIcms + "/nfe:CSOSN", nameSpace);
                        if (node != null)
                        {
                            produto.CstIcms = node.InnerXml.ToString();
                        }
                        node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:ICMS/nfe:ICMSSN" + sIcms + "/nfe:pCredSN", nameSpace);

                        if (node != null)
                        {
                            produto.AliqIcms = node.InnerXml.ToString();
                        }
                        else
                        {
                            produto.AliqIcms = "0";
                        }

                        node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:ICMS/nfe:ICMSSN" + sIcms + "/nfe:vCredICMSSN", nameSpace);

                        if (node != null)
                        {
                            produto.ValIcms = node.InnerXml.ToString();
                        }
                        else
                        {
                            produto.ValIcms = "0";
                        }

                        if (this.CRT == "1")
                        {
                            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:ICMS/nfe:ICMSSN" + sIcms + "/nfe:vBC", nameSpace);
                        }
                        else
                        {
                            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:ICMS/nfe:ICMS" + sIcms + "/nfe:vBC", nameSpace);
                        }

                        node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:ICMS/nfe:ICMSSN" + sIcms + "/nfe:vBC", nameSpace);
                        if (node != null)
                        {
                            produto.dBc = produto.ValIcms = node.InnerXml.ToString();
                        }
                        else
                        {
                            produto.dBc = "0";
                        }

                        node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:ICMS/nfe:ICMSSN" + sIcms + "/nfe:pRedBC", nameSpace);
                        if (node != null)
                        {
                            bAliqRedBCIcms = node.InnerXml.ToString();
                        }
                        else { 
                            bAliqRedBCIcms = "0";
                        }

                        node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:ICMS/nfe:ICMSSN" + sIcms + "/nfe:pRedBCST", nameSpace);
                        if (node != null)
                        {
                            bAliqRedBCSTIcms = node.InnerXml.ToString();
                        }
                        else { 
                            bAliqRedBCSTIcms = "0";
                        }

                        if (this.CRT == "1")
                        {
                            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:ICMS/nfe:ICMSSN" + sIcms + "/nfe:pMVAST", nameSpace);
                        }
                        else
                        {
                            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:ICMS/nfe:ICMSSN" + sIcms + "/nfe:pMVAST", nameSpace);
                        }

                        if (node != null)
                        {
                            produto.dMvaST = node.InnerXml.ToString();
                        }
                        else
                        {
                            produto.dMvaST = "0";
                        }

                        node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:ICMS/nfe:ICMSSN" + sIcms + "/nfe:vBCST", nameSpace);

                        if (node != null)
                        {
                            dValBcSTIcms = node.InnerXml.ToString();
                        }
                        else { 
                                dValBcSTIcms = "0";
                        }

                        node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:ICMS/nfe:ICMSSN" + sIcms + "/nfe:vCredICMSSN", nameSpace);
                        if (node != null)
                        {
                            dValIcmsSt = node.InnerXml.ToString();
                        }
                        else {
                            dValIcmsSt = "0";
                        }

                        node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:ICMS/nfe:ICMSSN" + sIcms + "/nfe:pICMSST", nameSpace);
                        if(node != null){
                            produto.dAliqIcmsSt = node.InnerXml.ToString();
                        }
                        else {
                            produto.dAliqIcmsSt = "0";
                        }

                        node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:ICMS/nfe:ICMSSN" + sIcms + "/nfe:orig", nameSpace);
                        if(node != null){
                            sOrigCST = "'" + node.InnerXml.ToString().Substring(0, 1) + "'";
                        }else { 
                            sOrigCST = "NULL";
                        }

                        node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:ICMS/nfe:ICMSSN" + sIcms + "/nfe:pRedBC", nameSpace);
                        if (node != null)
                        {
                            produto.bRedBC = node.InnerXml.ToString();
                        }
                        else
                        {
                            produto.bRedBC = "0";
                        }
                        //Fim do Icms Simples Nacional
                    }
                    else
                    {
                        var sIcms = PegaIcms(xml, 1);


                            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:ICMS/nfe:ICMS" + sIcms + "/nfe:pRedBC", nameSpace);
                            if (node != null)
                            {
                                produto.bRedBC = node.InnerXml.ToString();
                            }
                            else
                            {
                                produto.bRedBC = "0";
                            }

                            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:ICMS/nfe:ICMS" + sIcms + "/nfe:CST", nameSpace);
                            if (node != null)
                            {
                                if (node.InnerXml.ToString().Length >= 3)
                                {
                                    sCstIcms = "'" + node.InnerXml.ToString().Substring(0, 3) + "'";
                                }                                
                            }
                            else {
                                sCstIcms = "NULL";
                            }

                            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:ICMS/nfe:ICMS" + sIcms + "/nfe:pICMS", nameSpace);
                            if (node != null)
                            {
                                dAliqIcms = node.InnerXml.ToString();
                            }
                            else {
                                dAliqIcms = "0";
                            }

                            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:ICMS/nfe:ICMS" + sIcms + "/nfe:vICMS", nameSpace);
                            if (node != null)
                            {
                                dValIcms = node.InnerXml.ToString();
                            }
                            else {
                                dValIcms = "0";
                            }

                            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:ICMS/nfe:ICMS" + sIcms + "/nfe:vBC", nameSpace);
                            if (node != null)
                            {
                                dValBcIcms = node.InnerXml.ToString();
                            }
                            else {
                                dValBcIcms = "0";
                            }

                            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:ICMS/nfe:ICMS" + sIcms + "/nfe:pRedBC", nameSpace);
                            if (node != null)
                            {
                                bAliqRedBCIcms = node.InnerXml.ToString();
                            }
                            else {
                                bAliqRedBCIcms = "0";
                            }

                            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:ICMS/nfe:ICMS" + sIcms + "/nfe:pRedBCST", nameSpace);
                            if (node != null)
                            {
                                bAliqRedBCSTIcms = node.InnerXml.ToString();
                            }
                            else {
                                bAliqRedBCSTIcms = "0";
                            }

                            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:ICMS/nfe:ICMS" + sIcms + "/nfe:pMVAST", nameSpace);
                            if (node != null)
                            {
                                produto.dAliqMvaST = node.InnerXml.ToString();
                            }
                            else {
                                produto.dAliqMvaST = "0";
                            }

                            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:ICMS/nfe:ICMS" + sIcms + "/nfe:vBCST", nameSpace);
                            if (node != null)
                            {
                                dValBcSTIcms = node.InnerXml.ToString();
                            }
                            else {
                                dValBcSTIcms = "0";
                            }

                            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:ICMS/nfe:ICMS" + sIcms + "/nfe:vICMSST", nameSpace);
                            if (node != null)
                            {
                                dValIcmsSt = node.InnerXml.ToString();
                            }
                            else {
                                dValIcmsSt = "0";
                            }

                            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:ICMS/nfe:ICMS" + sIcms + "/nfe:pICMSST", nameSpace);
                            if (node != null)
                            {
                                dAliqIcmsSt = node.InnerXml.ToString();
                            }
                            else {
                                dAliqIcmsSt = "0";
                            }

                            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:ICMS/nfe:ICMS" + sIcms + "/nfe:orig", nameSpace);
                            if (node != null)
                            {
                                sOrigCST = "'" + node.InnerXml.ToString().Substring(0, 1) + "'";
                            }
                            else {
                                sOrigCST = "NULL";
                            }

                            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:ICMS/nfe:ICMSSN" + sIcms + "/nfe:CSOSN", nameSpace);


                            node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:ICMS/nfe:ICMS" + sIcms + "/nfe:CST", nameSpace);

                            if (CRT.ToString() == "1")
                            {
                                node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:ICMS/nfe:ICMSSN" + sIcms + "/nfe:CSOSN", nameSpace);
                            }
                            else
                            {
                                node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:ICMS/nfe:ICMS" + sIcms + "/nfe:CST", nameSpace);
                            }

                            if (node != null)
                            {
                                produto.sCst = node.InnerXml.ToString().Replace(".", ",");
                            }

                            for (var j = 0; j <= matriz.GetUpperBound(0); j++)
                            {

                                if (produto.sCst == matriz[j])
                                {
                                    produto.bSimST = true;
                                    produto.bValMvaSt = true;
                                    produto.bValBcSt = true;
                                }
                            }

                            for (int j = 0; j <= matrizComRed.GetUpperBound(0); j++)
                            {
                                if (produto.sCst == matrizComRed[j])
                                {
                                    produto.bValComReducao = true;
                                }
                            }

                            for (int j = 0; j <= matrizAliqIcms.GetUpperBound(0); j++)
                            {
                                if (produto.sCst == matrizAliqIcms[j])
                                {
                                    produto.bValAliqIcms = true;
                                }
                            }
                        }

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
                            this.vBCCofins += Convert.ToDouble(node.InnerXml.ToString());
                            produto.vBCCofins = node.InnerXml.ToString();
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
                            this.vCOFINS += Convert.ToDouble(node.InnerXml.ToString());
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
                        this.BasePis += Convert.ToDouble(node.InnerXml.ToString());
                        produto.BasePis = node.InnerXml.ToString();
                    }

                    //Valor do Pis
                    node = xpathNav.SelectSingleNode("//nfe:infNFe/nfe:det[" + i + "]/nfe:imposto/nfe:PIS/nfe:PISAliq/nfe:vPIS", nameSpace);
                    if (node != null)
                    {
                        this.ValorPis += Convert.ToDouble(node.InnerXml.ToString());
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
                //Determina o TipoNF
                    verificaEmpresa = this.dbXml.consultaErp(sqlVerificaEmpresa);
                    //Se o emitente estiver no sigamat então o tipo da nota será saída
                    if (verificaEmpresa.Count > 0)
                    {                            
                        this.CnpjCliFor = this.CnpjDestinatario;
                        this.nomeCliFor = this.NomeDestinatario;
                        this.TipoNf = "SAIDA";
                    }
                    else
                    {
                        this.CnpjCliFor = this.CnpjEmitente;
                        this.nomeCliFor = this.NomeEmitente;
                        this.TipoNf = "ENTRADA";
                    }

                    //Determina se a nota é de transferência
                    if (this.CnpjDestinatario.Length > 8)
                    {
                        if (this.CnpjEmitente.Substring(0, 8) == this.CnpjDestinatario.Substring(0, 8))
                        {
                            var qryRegra = "SELECT ATIVO FROM REGRASXML WHERE TIPO_VALIDACAO = 'SAIDA' AND ORDEM = 1 AND TIPO = 'S' AND PROCESSO = 'SAIDA'";
                            var processa = this.dbXml.consultaErp(qryRegra);
                            if (processa[0] == "1")
                            {
                                this.TipoNf = "TRANSF_ENTSAI";
                            }
                            else
                            {
                                this.TipoNf = "TRANSF_ENT";
                            }
                        }

                    }
                    //Determina se é nota de importação
                    if (produto.CFOP.Substring(0, 1) == "3")
                    {
                        this.TipoNf = "ENT_IMP";
                    }


                    if (produto.CFOP.Substring(0, 1) == "7")
                    {
                        this.TipoNf = "SAIDA";
                        this.Exportacao = true;
                    }


                    if (!this.carregaDadosErp())
                    {
                        break;
                    }
                        
                    //Carrega o código do produto do ERP
                    string query = FuncoesErp.sqlCodProdErp(this.tipoErp, produto.NCM, this.TabSB1, this.CodFilErp);
                    var lista = this.dbErp.consultaErp(query);
                    try
                    {
                        if (lista.Count == 0)
                        {
                            this.xmlCriticado = true;
                            this.msgCritica = "Produto com NCM: " + produto.NCM + " não foi encontrado no ERP";
                            var queryPrd = "INSERT INTO CRITICAXML (CODFILIAL, NOME_XML, DATAEMISSAO, CNPJ, RAZAO, SETOR, ITEM_XML, COD_PRD_AUX, DESC_PRD, UND_MED, CRITICA, TIPO, FLAG_STATUS) VALUES " +
                                                                            "('" + this.CodFilErp + "', '" + this.nomeArquivo + "', '" + this.DataEmissao + "', '" + this.CnpjEmitente + "', '" + this.NomeEmitente + "', 'CMP', '" + produto.numItem + "', '" + produto.codProdErp + "', '" + produto.xProd + "', '" + produto.uCom + "', 'PRODUTO NAO CADASTRADO | NCM:" + produto.NCM +"' , 'C', 'E')";
                            this.dbXml.execQuery(queryPrd);

                                break;
                            }
                            else
                            {
                                produto.codProdErp = lista[0];
                                produto.codFilialProdErp = lista[1];
                                produto.TpProd = lista[2];
                                produto.uCom = lista[3];
                            }
                        }
                    catch (Exception ex)
                    {
                        this.xmlCriticado = true;
                        this.msgCritica = "Produto não cadastrado! " + ex.ToString();
                        Console.ForegroundColor = System.ConsoleColor.Red;
                        Console.WriteLine("         Erro na função carregaAtributos(): " + ex.ToString());
                        Console.ForegroundColor = System.ConsoleColor.Gray;
                        break;
                        
                    }

                    //Atribui o campo TES                    
                    query = FuncoesErp.sqlTES(this.tipoErp, produto.codProdErp, produto.codFilialProdErp, this.CodEmpErp, this.TipoNf, this.codTabProd, this.TabSF4);
                    lista = this.dbErp.consultaErp(query);
                    try
                    {
                        if (lista.Count > 0)
                        {
                            produto.CompCfop = lista[0];
                            produto.TES = lista[1];
                        }
                    }
                    catch (Exception ex)
                    {
                        this.xmlCriticado = true;
                        this.msgCritica = ex.ToString();
                            Console.WriteLine("         Erro: " + ex.ToString());                        
                    }
                    var qryGrupTrib = FuncoesErp.sqlGrupoTrib(this.codTabProd, produto.codProdErp, this.CodFilErp);
                    var grupTrib = this.dbErp.consultaErp(qryGrupTrib);
                    if (grupTrib.Count > 0)
                    {
                        produto.GrpTrib = grupTrib[0];
                    }
                    else
                    {
                        produto.GrpTrib = "";
                    }

                    var qryPauta = FuncoesErp.sqlPauta(this.CodEmpErp, this.UFEmitente, this.CodFilErp, produto.GrpTrib);
                    var pauta = this.dbErp.consultaErp(qryPauta);
                    if (pauta.Count > 0)
                    {
                        produto.dFatorMva = Convert.ToDouble(pauta[0]);
                        produto.dVAliqPauta = Convert.ToDouble(pauta[1]);
                        produto.dVPrecoPauta = Convert.ToDouble(pauta[2]);
                    }



                        //Validação Fiscal 1
                        if (!(produto.dVPrecoPauta > 0))
                    {
                        if (produto.dMvaST == "0"  && produto.bValMvaSt)
                        {
                                this.xmlCriticado = true;
                                this.msgCritica = "MVA NAO DESTACADO NO XML, CST UTILIZADO OBRIGA PREENCHIMENTO DE INFORMACOES ST";
                                var queryErroCst = "INSERT INTO CRITICAXML (CODFILIAL, NOME_XML, DATAEMISSAO, CNPJ, RAZAO, SETOR, ITEM_XML, COD_PRD, COD_PRD_AUX, DESC_PRD, VALOR_PRD, CST, ALIQ_ICMS, ALIQ_ICMSST, RED_BC, CRITICA, TIPO) " +
                                    "VALUES ('" + this.CodFilErp + "', '" + this.nomeArquivo + "', '" + this.DataEmissao + "', '" + this.CnpjEmitente + "', '" + this.NomeEmitente + "', 'FIS', '" + i + "', '" + produto.codProdErp + "', '" + produto.codProdErp + "', " +
                                    "'" + produto.xProd + "', '" + produto.vProd.ToString() + "', '" + produto.sCst + "', '" + produto.AliqIcms + "', '" + dAliqIcmsSt + "', '" + produto.bRedBC + "', 'MVA NAO DESTACADO NO XML, CST UTILIZADO OBRIGA PREENCHIMENTO DE INFORMACOES ST', 'A')";

                                this.dbXml.execQuery(queryErroCst);
                            }

                    }
                    else if ((Convert.ToDouble(produto.dMvaST) != produto.dFatorMva) && Convert.ToDouble(produto.dMvaST) > 0)
                    {
                        this.xmlCriticado = true;
                        this.msgCritica = "DIVERGENCIA NO VALOR MVA XML X MVA CADASTRADO NAS EXCECOES FISCAIS";
                        var queryErroCst = "INSERT INTO CRITICAXML (CODFILIAL, NOME_XML, DATAEMISSAO, CNPJ, RAZAO, SETOR, ITEM_XML, COD_PRD, COD_PRD_AUX, DESC_PRD, VALOR_PRD, CST, ALIQ_ICMS, ALIQ_ICMSST, RED_BC, VALOR_MVA_XML, " +
                            "VALOR_MVA_PRD, CRITICA, TIPO) VALUES ('" + this.CodFilErp + "', '" + this.nomeArquivo + "', '" + this.DataEmissao + "', '" + this.CnpjEmitente + "', '" + this.NomeEmitente + "', 'FIS', '" + i + "', '" + produto.codProdErp + "', '" + produto.codProdErp + "', " +
                            "'" + produto.xProd + "', '" + produto.vProd + "', '" + produto.sCst + "', '" + produto.AliqIcms + "', '" + produto.dAliqIcmsSt + "', '" + produto.bRedBC + "', '" + produto.dMvaST + "', '" + produto.dFatorMva + "', " +
                            "'DIVERGENCIA NO VALOR MVA XML X MVA CADASTRADO NAS EXCECOES FISCAIS', 'A')";
                        this.dbXml.execQuery(queryErroCst);
                    }

                    //Validação Fiscal 2
                    if (Convert.ToDouble(produto.bRedBC) > 0 && produto.bValComReducao)
                    {
                        produto.dBcCalc = Convert.ToDouble(produto.vProd) - (Convert.ToDouble(produto.vProd) * (Convert.ToDouble(produto.bRedBC) / 100));
                        if (!(produto.dVPrecoPauta > 0))
                        {
                            if (Convert.ToDouble(produto.dBc) == Math.Round(produto.dBcCalc, 2))
                            {
                                var qryMva = "INSERT INTO CRITICAXML (CODFILIAL, NOME_XML, DATAEMISSAO, CNPJ, RAZAO, SETOR, ITEM_XML, COD_PRD, COD_PRD_AUX, DESC_PRD, VALOR_PRD, CST, ALIQ_ICMS, ALIQ_ICMSST, RED_BC, CRITICA, TIPO) " +
                                                    "VALUES ('" + this.CodFilErp + "', '" + this.nomeArquivo + "', '" + this.DataEmissao + "', '" + this.CnpjEmitente + "', '" + this.NomeEmitente + "', 'FIS', '" + i + "', '" + produto.codProdErp + "', '" + produto.codProdErp + "', " +
                                                    "'" + produto.xProd + "', '" + produto.vProd + "', '" + produto.CST + "', '" + produto.AliqIcms + "', '" + produto.dAliqIcmsSt + "', '" + produto.bRedBC + "', 'MVA NAO DESTACADO NO XML, CST UTILIZADO OBRIGA PREENCHIMENTO DE INFORMACOES ST', 'A')";
                                this.dbXml.execQuery(qryMva);
                            }
                        }
                    } else if (Convert.ToDouble(produto.dMvaST) != produto.dFatorMva && Convert.ToDouble(produto.dMvaST) > 0)
                    {
                            var qryMva2 = "INSERT INTO CRITICAXML (CODFILIAL, NOME_XML, DATAEMISSAO, CNPJ, RAZAO, SETOR, ITEM_XML, COD_PRD, COD_PRD_AUX, DESC_PRD, VALOR_PRD, CST, ALIQ_ICMS, ALIQ_ICMSST, RED_BC, VALOR_MVA_XML, " +
                                                   "VALOR_MVA_PRD, CRITICA, TIPO) VALUES ('" + this.CodFilErp + "', '" + this.nomeArquivo + "', '" + this.DataEmissao + "', '" + this.CnpjEmitente + "', '" + this.NomeEmitente + "', 'FIS', '" + i + "', '" + produto.codProdErp + "', '" + produto.codProdErp + "', " +
                                                   "'" + produto.xProd + "', '" + produto.vProd + "', '" + produto.CST + "', '" + produto.AliqIcms + "', '" + produto.dAliqIcmsSt + "', '" + produto.bRedBC + "', '" + produto.dMvaST + "', '" + produto.dFatorMva + "', " +
                                                   "'DIVERGENCIA NO VALOR MVA XML X MVA CADASTRADO NAS EXCECOES FISCAIS', 'A')";
                    }



                    this.Itens.Add(produto);
                    i++;                    
                }
            }
        }

        //Validações



        } //Fim da função

        public bool carregaDadosErp()
        {
            string query = FuncoesErp.sqlEmpresaErp(this.tipoErp, this.TipoNf == "ENTRADA" ? this.CnpjDestinatario : this.CnpjEmitente);
            var lista = this.dbXml.consultaErp(query);

                        
            try
            {
                if (lista.Count > 0)
                {
                    this.CodEmpErp = lista[0];
                    this.CodFilErp = lista[1];

                    this.TabSA2 = this.dbXml.consultaErp(FuncoesErp.pegaTabelaSx2(this.CodEmpErp, "SA2"))[0];
                    this.TabSA1 = this.dbXml.consultaErp(FuncoesErp.pegaTabelaSx2(this.CodEmpErp, "SA1"))[0];
                    this.TabSA4 = this.dbXml.consultaErp(FuncoesErp.pegaTabelaSx2(this.CodEmpErp, "SA4"))[0];
                    this.TabSB1 = this.dbXml.consultaErp(FuncoesErp.pegaTabelaSx2(this.CodEmpErp, "SB1"))[0];
                    this.TabSC5 = this.dbXml.consultaErp(FuncoesErp.pegaTabelaSx2(this.CodEmpErp, "SC5"))[0];
                    this.TabSC6 = this.dbXml.consultaErp(FuncoesErp.pegaTabelaSx2(this.CodEmpErp, "SC6"))[0];
                    this.TabSC9 = this.dbXml.consultaErp(FuncoesErp.pegaTabelaSx2(this.CodEmpErp, "SC9"))[0];
                    this.TabSD1 = this.dbXml.consultaErp(FuncoesErp.pegaTabelaSx2(this.CodEmpErp, "SD1"))[0];
                    this.TabSD2 = this.dbXml.consultaErp(FuncoesErp.pegaTabelaSx2(this.CodEmpErp, "SD2"))[0];
                    this.TabSF1 = this.dbXml.consultaErp(FuncoesErp.pegaTabelaSx2(this.CodEmpErp, "SF1"))[0];
                    this.TabSF2 = this.dbXml.consultaErp(FuncoesErp.pegaTabelaSx2(this.CodEmpErp, "SF2"))[0];
                    this.TabSF4 = this.dbXml.consultaErp(FuncoesErp.pegaTabelaSx2(this.CodEmpErp, "SF4"))[0];
                    this.TabSF7 = this.dbXml.consultaErp(FuncoesErp.pegaTabelaSx2(this.CodEmpErp, "SF7"))[0];
                    //Query para pegar a tabela dos produtos do ERP
                    query = FuncoesErp.sqlTabProdErp(this.tipoErp, this.CodEmpErp);

                    lista = this.dbXml.consultaErp(query);
                    try
                    {
                        if (lista.Count > 0)
                        {
                            this.codTabProd = lista[1];
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        this.xmlCriticado = true;
                        this.msgCritica = ex.ToString();
                        return false;
                    }
                }
                else
                {
                    this.xmlCriticado = true;
                    this.msgCritica = "XML TRANSFERIDO PARA A PASTA CRITICADOS, O MESMO NAO PERTENCE AO GRUPO DA EMPRESA";
                    return false;
                }
            }
            catch (Exception ex)
            {
                this.xmlCriticado = true;
                
                return false;
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

        public void validacaoFiscal()
        {
            
            if (this.TipoNf != "ENT_IMP")
            {

            }
        }
    }
}
