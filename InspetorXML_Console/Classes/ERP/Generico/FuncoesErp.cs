using InspetorXML_Console.Classes.XML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspetorXML_Console.Classes.ERP.Generico
{
    class FuncoesErp
    {
        public static string sqlEmpresaErp(string tipoErp, string cnpjEmpresa)
        {
            if (tipoErp.ToLower() == "protheus")
            {
                return "SELECT M0_CODIGO, M0_CODFIL FROM SIGAMAT WHERE REPLACE(REPLACE(REPLACE(M0_CGC, '.', ''), '/', ''), '-', '') = '" + cnpjEmpresa + "'";
            }
            else
            {
                return "SELECT CODCOLIGADA, CODFILIAL FROM GFILIAL WHERE REPLACE(REPLACE(REPLACE(CGC, '.', ''), '/', ''), '-', '') = '" + cnpjEmpresa + "'"; ;
            }            
        }

        public static string sqlCliForErp(string tipoErp, string tipoNf, string cnpjCliFor, string codTab = "")
        {
            if (tipoErp.ToLower() == "protheus")
            {
                if (tipoNf == "ENTRADA")
                {
                    return "SELECT A2_COD, A2_LOJA, A2_MSBLQL, A2_COND FROM SA2" + codTab + "0 WHERE REPLACE(REPLACE(REPLACE(A2_CGC, '.', ''), '/', ''), '-', '') = '" + cnpjCliFor + "' AND D_E_L_E_T_ <> '*'";
                }
                else
                {
                    return "SELECT A1_COD, A1_LOJA, A1_MSBLQL, A1_COND FROM SA1" + codTab + "0 WHERE REPLACE(REPLACE(REPLACE(A1_CGC, '.', ''), '/', ''), '-', '') = '" + cnpjCliFor + "' AND D_E_L_E_T_ <> '*'";
                }
                
            }
            else
            {
                return "";
            }                            
            
        }

        public static string sqlTES(string tipoErp, string codProd, string codFilial, string CodEmpErp, string tpNF = "", string codTabProd = "")
        {
            if (tipoErp.ToLower() == "protheus")
            {
                string TipoEntSai;
                if (tpNF == "TRANSF_ENTSAI" || tpNF == "SAIDA")
                {
                    TipoEntSai = "B1.B1_TS";
                }
                else
                {
                    TipoEntSai = "B1.B1_TE";
                }
                return "SELECT SUBSTRING(F4.F4_CF, 2, 3) AS COMPCFOP, F4.F4_CODIGO FROM SF4" + CodEmpErp + "0 F4 INNER JOIN " + codTabProd + " B1 ON F4.F4_CODIGO = " + TipoEntSai + " WHERE " +
                        "B1.B1_COD = '" + codProd + "' AND B1.B1_FILIAL = '" + codFilial + "' AND F4.F4_FILIAL = '" + codFilial + "' AND B1.D_E_L_E_T_ <> '*' AND F4.D_E_L_E_T_ <> '*'";
            }
            else
            {
                return "";
            }
                
        }

        public static string sqlInsereItem(string tipoErp, string tipoNf, ProdutosNfe dadosProd, string codTab, string codFilial, string codCliFor, string NumNf, string DataEmissao, string serieNf, string CodLojaCliForErp = "")
        {
            var D1_FILIAL       = "'" + codFilial + "',";
            var D1_ITEM         = "'" + dadosProd.numItem + "',";
            var D1_COD          = "'" + dadosProd.codProdErp + "',";
            var D1_UM           = "'" + dadosProd.uCom + "',";
            var D1_QUANT        = "'" + dadosProd.qCom + "',";
            var D1_VUNIT        = "'" + dadosProd.vUnCom + "',";
            var D1_TOTAL        = "'" + dadosProd.vProd + "',";
            var D1_VALIPI       = "'" + dadosProd.vIPI + "',";
            var D1_VALICM       = "'" + dadosProd.vICMS + "',";
            var D1_TES          = "'" + dadosProd.TES + "',";
            //TODO: Implementar o CFOP com a Célia
            var D1_CF           = "'',";
            var D1_DESC         = "'" + dadosProd.vDesc + "',";
            var D1_IPI          = "'" + dadosProd.pIPI + "',";
            var D1_PICM         = "'" + dadosProd.PICM + "',";
            var D1_FORNECE      = "'" + codCliFor + "',";
            var D1_LOJA         = "'" + CodLojaCliForErp + "',";
            var D1_LOCAL        = "'" + CodLojaCliForErp + "',";
            var D1_DOC          = "'" + NumNf + "',";
            var D1_EMISSAO      = "REPLACE(CAST(CAST('" + DataEmissao + "' AS DATE) AS VARCHAR(20)), '-', ''),";
            var D1_DTDIGIT      = "REPLACE(CAST(CAST(GETDATE() AS DATE) AS VARCHAR(20)), '-', ''),";
            var D1_TIPO         = "'N',";
            var D1_SERIE        = "'" + serieNf + "',";
            var D1_TP           = "'" + dadosProd.TpProd + "',";
            var D1_BASEICM      = "'" + dadosProd.BaseIcms + "',";
            var D1_VALDESC      = "'" + dadosProd.vDesc + "',";
            var D1_BASEIPI      = "'" + dadosProd.BaseIpi + "',";
            var D1_BASIMP5      = "'" + dadosProd.BaseCofins + "',";
            var D1_BASIMP6      = "'" + dadosProd.BasePis + "',";
            var D1_VALIMP5      = "'" + dadosProd.vCOFINS + "',";
            var D1_VALIMP6      = "'" + dadosProd.ValorPis + "',";
            var D1_ALQIMP5      = "'" + dadosProd.pCOFINS + "',";
            var D1_ALQIMP6      = "'" + dadosProd.pPIS + "',";
            var D1_VALFRE       = "'" + dadosProd.vFrete + "',";
            var D1_SEGURO       = "'" + dadosProd.vDesc + "',";
            var D1_DESPESA      = "'" + dadosProd.vOutro + "',";
            var D1_STSERV       = "'1',";
            var D1_ALIQSOL      = "'" + dadosProd.PICM + "',";
            var D1_GARANTI      = "'N',";
            var D1_ALQCSL       = "'1',";
            var D1_ALQPIS       = "'" + dadosProd.pPIS + "',";
            var D1_ALQCOF       = "'" + dadosProd.pCOFINS + "',";
            var R_E_C_N_O_      = "(SELECT MAX(R_E_C_N_O_)+1 FROM SD1" + codTab +"0)";
            string query = "INSERT INTO SD1" + codTab + "0 (D1_FILIAL, D1_ITEM, D1_COD, D1_UM, D1_QUANT, D1_VUNIT, D1_TOTAL, D1_VALIPI, D1_VALICM, D1_TES, D1_CF, D1_DESC, D1_IPI,  D1_PICM,  D1_FORNECE,  D1_LOJA, D1_LOCAL, D1_DOC, D1_EMISSAO, D1_DTDIGIT, D1_TIPO, D1_SERIE, D1_TP, D1_BASEICM, D1_VALDESC, D1_BASEIPI, D1_BASIMP5, D1_BASIMP6, D1_VALIMP5, D1_VALIMP6, D1_ALQIMP5, D1_ALQIMP6, D1_VALFRE, D1_SEGURO, D1_DESPESA, D1_STSERV, D1_ALIQSOL, D1_GARANTI, D1_ALQCSL, D1_ALQPIS, D1_ALQCOF, R_E_C_N_O_)  VALUES (";
            query += D1_FILIAL + D1_ITEM + D1_COD + D1_UM + D1_QUANT + D1_VUNIT + D1_TOTAL + D1_VALIPI + D1_VALICM + D1_TES + D1_CF + D1_DESC + D1_IPI + D1_PICM + D1_FORNECE + D1_LOJA + D1_LOCAL + D1_DOC + D1_EMISSAO + D1_DTDIGIT + D1_TIPO + D1_SERIE + D1_TP + D1_BASEICM + D1_VALDESC + D1_BASEIPI + D1_BASIMP5 + D1_BASIMP6 + D1_VALIMP5 + D1_VALIMP6 + D1_ALQIMP5 + D1_ALQIMP6 + D1_VALFRE + D1_SEGURO + D1_DESPESA + D1_STSERV + D1_ALIQSOL + D1_GARANTI + D1_ALQCSL + D1_ALQPIS + D1_ALQCOF + R_E_C_N_O_;
            query += ");";
            return query;
        }

        public static string sqlTabProdErp(string tipoErp, string codTabEmp = "")
        {
            if (tipoErp.ToLower() == "protheus")
            {
                return "SELECT X2_CHAVE, X2_ARQUIVO FROM  SX2" + codTabEmp + "0 WHERE X2_CHAVE = 'SB1'";
            }
            //TODO: Escrever o código do RM
            else
            {
                return "";
            }
                        
        }

        public static string sqlCodProdErp(string tipoErp, string NCMProd, string prodTab, string codFilial)
        {
            if (tipoErp.ToLower() == "protheus")
            {
                return "SELECT B1_COD, B1_FILIAL, B1_TIPO FROM " + prodTab + " WHERE B1_POSIPI = '" + NCMProd + "' AND D_E_L_E_T_ <> '*'";
            }
            //Implementar query do RM
            else
            {
                return "";
            }
        }

        public static string sqlInsereCabecNf(string tipoErp, XmlNfe nota)
        {
            if (tipoErp.ToLower() == "protheus")
            {
                if (nota.TipoNf == "ENTRADA")
                {
                    var F1_FILIAL   = nota.CodFilErp;
                    var F1_DOC      = nota.NumNf;
                    var F1_SERIE    = nota.serieNf;
                    var F1_FORNECE  = nota.CodCliForErp;
                    var F1_LOJA     = nota.CodLojaCliForErp;
                    var F1_COND     = nota.CodCondPagto;
                    var F1_DUPL     = nota.NumNf;
                    var F1_EMISSAO  = nota.DataEmissao;
                    var F1_EST      = nota.UFEmitente;
                    var F1_FRETE    = nota.vFrete;
                    var F1_DESPESA  = nota.vOutro;
                    var F1_BASEICM  = nota.BaseIcms;
                    var F1_VALICM   = nota.vICMS;
                    var F1_BASEIPI  = Convert.ToDouble(nota.vIPI) > 0 ? Convert.ToString(Convert.ToDouble(nota.ValorBruto) + Convert.ToDouble(nota.vOutro) + Convert.ToDouble(nota.vFrete) + Convert.ToDouble(nota.vSeg)) : "0";
                    var F1_VALIPI   = nota.vIPI;
                    var F1_VALMERC  = nota.ValorBruto;
                    var F1_VALBRUT  = nota.ValorBruto;
                    var F1_TIPO     = "'N'";
                    var F1_DESCONT  = nota;
                    var F1_DTDIGIT = "";
                    var F1_ORIGLAN = "";
                    var F1_CONTSOC = "";
                    var F1_IRRF = "";
                    var F1_ESPECIE = "";
                    var F1_II = "";
                    var F1_BASIMP5 = "";
                    var F1_BASIMP6 = "";
                    var F1_VALIMP5 = "";
                    var F1_VALIMP6 = "";
                    var F1_SEGURO = "";
                    var F1_MOEDA = "";
                    var F1_PREFIXO = "";
                    var F1_STATUS = "";
                    var F1_RECBMTO = "";
                    var F1_RECISS = "";
                    var R_E_C_N_O_ = "";
                    var F1_CHVNFE = "";
                }
            }
        }
    }
}
