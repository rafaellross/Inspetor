using InspetorXML_Console.Classes.XML;
using System;
using System.Collections.Generic;
using System.IO;
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
                    return "SELECT A2_COD, A2_LOJA, A2_MSBLQL, A2_COND, A2_TIPO FROM SA2" + codTab + "0 WHERE REPLACE(REPLACE(REPLACE(A2_CGC, '.', ''), '/', ''), '-', '') = '" + cnpjCliFor + "' AND D_E_L_E_T_ <> '*'";
                }
                else
                {
                    return "SELECT A1_COD, A1_LOJA, A1_MSBLQL, A1_COND, A1_TIPO FROM SA1" + codTab + "0 WHERE REPLACE(REPLACE(REPLACE(A1_CGC, '.', ''), '/', ''), '-', '') = '" + cnpjCliFor + "' AND D_E_L_E_T_ <> '*'";
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

        //SD1	ITENS DAS NF’S DE ENTRADA | SD2	ITENS DE VENDA DA NF
        public static string sqlInsereItem(string tipoErp, string tipoNf, ProdutosNfe dadosProd, string codTab, string codFilial, string codCliFor, string NumNf, string DataEmissao, string serieNf, string CodLojaCliForErp = "")
        {
            string query = "";
            if (tipoErp.ToLower() == "protheus")
            {
                //Notas de Entrada
                if (tipoNf == "ENTRADA")
                                {
                    var D1_FILIAL = "'" + codFilial + "',";
                    var D1_ITEM = "'" + dadosProd.numItem + "',";
                    var D1_COD = "'" + dadosProd.codProdErp + "',";
                    var D1_UM = "'" + dadosProd.uCom + "',";
                    var D1_QUANT = "'" + dadosProd.qCom + "',";
                    var D1_VUNIT = "'" + dadosProd.vUnCom + "',";
                    var D1_TOTAL = "'" + dadosProd.vProd + "',";
                    var D1_VALIPI = "'" + dadosProd.vIPI + "',";
                    var D1_VALICM = "'" + dadosProd.vICMS + "',";
                    var D1_TES = "'" + dadosProd.TES + "',";
                    //TODO: Implementar o CFOP com a Célia
                    var D1_CF = "'" + dadosProd.CFOP + "',";
                    var D1_DESC = "'" + dadosProd.vDesc + "',";
                    var D1_IPI = "'" + dadosProd.pIPI + "',";
                    var D1_PICM = "'" + dadosProd.PICM + "',";
                    var D1_FORNECE = "'" + codCliFor + "',";
                    var D1_LOJA = "'" + CodLojaCliForErp + "',";
                    var D1_LOCAL = "'" + CodLojaCliForErp + "',";
                    var D1_DOC = "'" + NumNf + "',";
                    var D1_EMISSAO = "REPLACE(CAST(CAST('" + DataEmissao + "' AS DATE) AS VARCHAR(20)), '-', ''),";
                    var D1_DTDIGIT = "REPLACE(CAST(CAST(GETDATE() AS DATE) AS VARCHAR(20)), '-', ''),";
                    var D1_TIPO = "'N',";
                    var D1_SERIE = "'" + serieNf + "',";
                    var D1_TP = "'" + dadosProd.TpProd + "',";
                    var D1_BASEICM = "'" + dadosProd.BaseIcms + "',";
                    var D1_VALDESC = "'" + dadosProd.vDesc + "',";
                    var D1_BASEIPI = "'" + dadosProd.BaseIpi + "',";
                    var D1_BASIMP5 = "'" + dadosProd.BaseCofins + "',";
                    var D1_BASIMP6 = "'" + dadosProd.BasePis + "',";
                    var D1_VALIMP5 = "'" + dadosProd.vCOFINS + "',";
                    var D1_VALIMP6 = "'" + dadosProd.ValorPis + "',";
                    var D1_ALQIMP5 = "'" + dadosProd.pCOFINS + "',";
                    var D1_ALQIMP6 = "'" + dadosProd.pPIS + "',";
                    var D1_VALFRE = "'" + dadosProd.vFrete + "',";
                    var D1_SEGURO = "'" + dadosProd.vDesc + "',";
                    var D1_DESPESA = "'" + dadosProd.vOutro + "',";
                    var D1_STSERV = "'1',";
                    var D1_ALIQSOL = "'" + dadosProd.PICM + "',";
                    var D1_GARANTI = "'N',";
                    var D1_ALQCSL = "'1',";
                    var D1_ALQPIS = "'" + dadosProd.pPIS + "',";
                    var D1_ALQCOF = "'" + dadosProd.pCOFINS + "',";
                    var R_E_C_N_O_ = "(SELECT MAX(R_E_C_N_O_)+1 FROM SD1" + codTab + "0)";
                    query += "INSERT INTO SD1" + codTab + "0 (D1_FILIAL, D1_ITEM, D1_COD, D1_UM, D1_QUANT, D1_VUNIT, D1_TOTAL, D1_VALIPI, D1_VALICM, D1_TES, D1_CF, D1_DESC, D1_IPI,  D1_PICM,  D1_FORNECE,  D1_LOJA, D1_LOCAL, D1_DOC, D1_EMISSAO, D1_DTDIGIT, D1_TIPO, D1_SERIE, D1_TP, D1_BASEICM, D1_VALDESC, D1_BASEIPI, D1_BASIMP5, D1_BASIMP6, D1_VALIMP5, D1_VALIMP6, D1_ALQIMP5, D1_ALQIMP6, D1_VALFRE, D1_SEGURO, D1_DESPESA, D1_STSERV, D1_ALIQSOL, D1_GARANTI, D1_ALQCSL, D1_ALQPIS, D1_ALQCOF, R_E_C_N_O_)  VALUES (";
                    query += D1_FILIAL + D1_ITEM + D1_COD + D1_UM + D1_QUANT + D1_VUNIT + D1_TOTAL + D1_VALIPI + D1_VALICM + D1_TES + D1_CF + D1_DESC + D1_IPI + D1_PICM + D1_FORNECE + D1_LOJA + D1_LOCAL + D1_DOC + D1_EMISSAO + D1_DTDIGIT + D1_TIPO + D1_SERIE + D1_TP + D1_BASEICM + D1_VALDESC + D1_BASEIPI + D1_BASIMP5 + D1_BASIMP6 + D1_VALIMP5 + D1_VALIMP6 + D1_ALQIMP5 + D1_ALQIMP6 + D1_VALFRE + D1_SEGURO + D1_DESPESA + D1_STSERV + D1_ALIQSOL + D1_GARANTI + D1_ALQCSL + D1_ALQPIS + D1_ALQCOF + R_E_C_N_O_;
                    query += ");";

                }
                else
                                {
                    var D2_FILIAL   = "'" + codFilial + "',";
                    var D2_ITEM     = "'" + dadosProd.numItem + "',";
                    var D2_COD      = "'" + dadosProd.codProdErp + "',";
                    var D2_UM       = "'" + dadosProd.uCom + "',";
                    var D2_QUANT    = "'" + dadosProd.qCom + "',";
                    var D2_PRCVEN   = "'" + dadosProd.vUnCom + "',";
                    var D2_PRUNIT   = "'" + dadosProd.vUnCom + "',";
                    var D2_TOTAL    = "'" + dadosProd.vProd + "',";
                    var D2_VALBRUT  = "'" + dadosProd.vProd + "',";
                    var D2_VALIPI   = "'" + dadosProd.vIPI + "',";
                    var D2_VALICM   = "'" + dadosProd.vICMS + "',";
                    var D2_TES      = "'" + dadosProd.TES + "',";
                    var D2_CF       = "'" + dadosProd.CFOP + "',";
                    var D2_DESC     = "'" + dadosProd.vDesc + "',";
                    var D2_IPI      = "'" + dadosProd.vIPI + "',";
                    var D2_PICM     = "'" + dadosProd.PICM + "',";
                    var D2_CLIENTE  = "'" + codCliFor + "',";
                    var D2_LOJA     = "'" + CodLojaCliForErp + "',";
                    var D2_LOCAL    = "'" + CodLojaCliForErp + "',";
                    var D2_DOC      = "'" + NumNf + "',";
                    var D2_EMISSAO  = "REPLACE(CAST(CAST('" + DataEmissao + "' AS DATE) AS VARCHAR(20)), '-', ''),";
                    var D2_DTDIGIT  = "REPLACE(CAST(CAST(GETDATE() AS DATE) AS VARCHAR(20)), '-', ''),";
                    var D2_TIPO     = "'N',";
                    var D2_SERIE    = "'" + serieNf + "',";
                    var D2_TP       = "'" + dadosProd.TpProd + "',";
                    var D2_BASEICM  = "'" + dadosProd.BaseIcms + "',";
                    var D2_BASEIPI  = "'" + dadosProd.BaseIpi + "',";
                    var D2_BASIMP5  = "'" + dadosProd.BaseCofins + "',";
                    var D2_BASIMP6  = "'" + dadosProd.BasePis + "',";
                    var D2_VALIMP5  = "'" + dadosProd.vCOFINS + "',";
                    var D2_VALIMP6  = "'" + dadosProd.ValorPis + "',";
                    var D2_ALQIMP5  = "'" + dadosProd.pCOFINS + "',";
                    var D2_ALQIMP6  = "'" + dadosProd.pPIS + "',";
                    var D2_VALFRE   = "'" + dadosProd.vFrete + "',";
                    var D2_SEGURO   = "'" + dadosProd.vSeg + "',";
                    var D2_DESPESA  = "'" + dadosProd.vOutro + "',";
                    var D2_STSERV   = "'1',";
                    var D2_ALIQSOL  = "'" + dadosProd.PICM + "',";
                    var D2_ALQCSL   = "'1',";
                    var D2_ALQPIS   = "'" + dadosProd.pPIS + "',";
                    var D2_ALQCOF   = "'" + dadosProd.pCOFINS + "',";
                    var R_E_C_N_O_  = "(SELECT MAX(R_E_C_N_O_)+1 FROM SD2" + codTab + "0),";
                    //Implementar ICMS
                    var D2_CLASFIS = "''";
                    query += "INSERT INTO SD2" + codTab + "0 (D2_FILIAL,D2_ITEM,D2_COD,D2_UM,D2_QUANT,D2_PRCVEN,D2_PRUNIT,D2_TOTAL,D2_VALBRUT," +
                        "D2_VALIPI,D2_VALICM,D2_TES,D2_CF,D2_DESC,D2_IPI, D2_PICM, D2_CLIENTE, D2_LOJA,D2_LOCAL,D2_DOC,D2_EMISSAO,D2_DTDIGIT,D2_TIPO,D2_SERIE,D2_TP,D2_BASEICM," +
                        "D2_BASEIPI,D2_BASIMP5,D2_BASIMP6,D2_VALIMP5,D2_VALIMP6,D2_ALQIMP5,D2_ALQIMP6,D2_VALFRE,D2_SEGURO,D2_DESPESA,D2_STSERV," +
                        "D2_ALIQSOL,D2_ALQCSL,D2_ALQPIS,D2_ALQCOF,R_E_C_N_O_,D2_CLASFIS) ";
                    query += " VALUES(";
                    query += D2_FILIAL + D2_ITEM + D2_COD + D2_UM + D2_QUANT + D2_PRCVEN + D2_PRUNIT + D2_TOTAL + D2_VALBRUT + D2_VALIPI + D2_VALICM + D2_TES + D2_CF + D2_DESC + D2_IPI + D2_PICM + D2_CLIENTE + D2_LOJA + D2_LOCAL + D2_DOC + D2_EMISSAO + D2_DTDIGIT + D2_TIPO + D2_SERIE + D2_TP + D2_BASEICM + D2_BASEIPI + D2_BASIMP5 + D2_BASIMP6 + D2_VALIMP5 + D2_VALIMP6 + D2_ALQIMP5 + D2_ALQIMP6 + D2_VALFRE + D2_SEGURO + D2_DESPESA + D2_STSERV + D2_ALIQSOL + D2_ALQCSL + D2_ALQPIS + D2_ALQCOF + R_E_C_N_O_ + D2_CLASFIS;
                    query += ");";
                }
            }
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
                return "SELECT TOP 1 B1_COD, B1_FILIAL, B1_TIPO FROM " + prodTab + " WHERE B1_POSIPI = '" + NCMProd + "' AND D_E_L_E_T_ <> '*'";
            }
            //Implementar query do RM
            else
            {
                return "";
            }
        }

        //SF1	CABECALHO DAS NF’S DE ENTRADA / SF2	CABECALHO DAS NF’S DE SAIDA
        public static string sqlInsereCabecNf(string tipoErp, XmlNfe nota)
        {
            string query = "";
            if (tipoErp.ToLower() == "protheus")
            {
                //Notas de Entrada
                if (nota.TipoNf == "ENTRADA")
                                {
                    var F1_FILIAL   = "'" + nota.CodFilErp + "',";
                    var F1_DOC      = "'" + nota.NumNf + "',";
                    var F1_SERIE    = "'" + nota.serieNf + "',";
                    var F1_FORNECE  = "'" + nota.CodCliForErp + "',";
                    var F1_LOJA     = "'" + nota.CodLojaCliForErp + "',";
                    var F1_COND     = "'" + nota.CodCondPagto + "',";
                    var F1_DUPL     = "'" + nota.NumNf + "',";                    
                    var F1_EMISSAO  = "REPLACE(CAST(CAST('" + nota.DataEmissao + "' AS DATE) AS VARCHAR(20)), '-', ''),";
                    var F1_EST      = "'" + nota.UFEmitente + "',";
                    var F1_FRETE    = "'" + nota.vFrete + "',";
                    var F1_DESPESA  = "'" + nota.vOutro + "',";
                    var F1_BASEICM  = "'" + nota.BaseIcms + "',";
                    var F1_VALICM   = "'" + nota.vICMS + "',";
                    var F1_BASEIPI  = "'" + (Convert.ToDouble(nota.vIPI) > 0 ? Convert.ToString(Convert.ToDouble(nota.ValorBruto) + Convert.ToDouble(nota.vOutro) + Convert.ToDouble(nota.vFrete) + Convert.ToDouble(nota.vSeg)) : "0") + "',";
                    var F1_VALIPI   = "'" + nota.vIPI + "',";
                    var F1_VALMERC  = "'" + nota.ValorBruto + "',";
                    var F1_VALBRUT  = "'" + nota.ValorBruto + "',";
                    var F1_TIPO     = "'N',";
                    var F1_DESCONT  = "'" + nota.vDesc + "',";
                    var F1_DTDIGIT  = "REPLACE(CAST(CAST(GETDATE() AS DATE) AS VARCHAR(20)), '-', ''),";
                    var F1_ORIGLAN  = "'PX',";
                    var F1_CONTSOC  = "0,";
                    var F1_IRRF     = "0,";
                    var F1_ESPECIE  = "'" + nota.EspNf + "',";
                    var F1_II       = "'0',";
                    var F1_BASIMP5  = "'" + nota.vBCCofins.ToString() + "',";
                    var F1_BASIMP6  = "'" + nota.BasePis + "',";
                    var F1_VALIMP5  = "'" + nota.vCOFINS.ToString() + "',";
                    var F1_VALIMP6  = "'" + nota.ValorPis + "',";
                    var F1_SEGURO   = "'" + nota.vSeg + "',";
                    var F1_MOEDA    = "1,";
                    var F1_PREFIXO  = "1,";
                    var F1_STATUS   = "'',";
                    var F1_RECBMTO  = "REPLACE(CAST(CAST(GETDATE() AS DATE) AS VARCHAR(20)), '-', ''),";
                    var F1_RECISS   = "2,";
                    var R_E_C_N_O_  = "(SELECT MAX(R_E_C_N_O_)+1 FROM SF1" + nota.CodEmpErp + "0),";
                    var F1_CHVNFE   = "'" + nota.ChaveNfe + "'";

                    query = "INSERT INTO SF1" + nota.CodEmpErp + "0 (F1_FILIAL, F1_DOC, F1_SERIE, F1_FORNECE, F1_LOJA, F1_COND, F1_DUPL, F1_EMISSAO, F1_EST, F1_FRETE, F1_DESPESA, F1_BASEICM, F1_VALICM, F1_BASEIPI, F1_VALIPI, F1_VALMERC, F1_VALBRUT, F1_TIPO, F1_DESCONT, F1_DTDIGIT, F1_ORIGLAN, F1_CONTSOC, F1_IRRF, F1_ESPECIE, F1_II, F1_BASIMP5, F1_BASIMP6, F1_VALIMP5, F1_VALIMP6, F1_SEGURO, F1_MOEDA, F1_PREFIXO, F1_STATUS, F1_RECBMTO, F1_RECISS, R_E_C_N_O_, F1_CHVNFE) VALUES(";
                    query += F1_FILIAL + F1_DOC + F1_SERIE + F1_FORNECE + F1_LOJA + F1_COND + F1_DUPL + F1_EMISSAO + F1_EST + F1_FRETE + F1_DESPESA + F1_BASEICM + F1_VALICM + F1_BASEIPI + F1_VALIPI + F1_VALMERC + F1_VALBRUT + F1_TIPO + F1_DESCONT + F1_DTDIGIT + F1_ORIGLAN + F1_CONTSOC + F1_IRRF + F1_ESPECIE + F1_II + F1_BASIMP5 + F1_BASIMP6 + F1_VALIMP5 + F1_VALIMP6 + F1_SEGURO + F1_MOEDA + F1_PREFIXO + F1_STATUS + F1_RECBMTO + F1_RECISS + R_E_C_N_O_ + F1_CHVNFE;
                    query += ");";
                }
                //Notas de Saída
                else
                {
                    var F2_FILIAL       = nota.CodFilErp;
                    var F2_DOC          = nota.NumNf;
                    var F2_SERIE        = nota.serieNf;
                    var F2_CLIENTE      = nota.CodCliForErp;
                    var F2_CLIENT       = nota.CodCliForErp;
                    var F2_LOJA         = nota.CodLojaCliForErp;
                    var F2_LOJENT       = nota.CodLojaCliForErp;
                    var F2_COND         = nota.CodCondPagto;
                    var F2_DUPL         = nota.NumNf;
                    var F2_EMISSAO      = nota.DataEmissao;
                    var F2_EST          = nota.UFDestinatario;
                    var F2_FRETE        = nota.vFrete;
                    var F2_DESPESA      = nota.vOutro;
                    var F2_BASEICM      = nota.BaseIcms;
                    var F2_VALICM       = nota.ValorIcms;
                    var F2_BASEIPI      = "'" + (Convert.ToDouble(nota.vIPI) > 0 ? Convert.ToString(Convert.ToDouble(nota.ValorBruto) + Convert.ToDouble(nota.vOutro) + Convert.ToDouble(nota.vFrete) + Convert.ToDouble(nota.vSeg)) : "0") + "',";
                    var F2_VALIPI       = nota.vIPI;
                    var F2_VALMERC      = nota.ValorBruto;
                    var F2_VALBRUT      = nota.ValorBruto;
                    var F2_TIPO         = "N";
                    var F2_DESCONT      = nota.vDesc;
                    var F2_DTDIGIT      = "REPLACE(CAST(CAST(GETDATE() AS DATE) AS VARCHAR(20)), '-', ''),";
                    var F2_CONTSOC      = "0";
                    var F2_ESPECIE      = nota.EspNf;
                    var F2_BASIMP5      = nota.vBCCofins;
                    var F2_BASIMP6      = nota.BasePis;
                    var F2_VALIMP5      = nota.vCOFINS;
                    var F2_VALIMP6      = nota.ValorPis;
                    var F2_SEGURO       = nota.vSeg;
                    var F2_MOEDA        = "1";
                    var F2_PREFIXO      = "1";
                    var F2_RECISS       = "2";
                    var R_E_C_N_O_      = "(SELECT MAX(R_E_C_N_O_)+1 FROM SF2" + nota.CodEmpErp + ")";
                    var F2_ICMFRET      = "0";
                    var F2_TIPOCLI      = nota.CodTipoCliFor;
                    var F2_VOLUME1      = nota.qVol;
                    var F2_VOLUME2      = "0";
                    var F2_VOLUME3      = "0";
                    var F2_VOLUME4      = "0";
                    var F2_ICMSRET      = "0";
                    var F2_PLIQUI       = nota.pesoL;
                    var F2_PBRUTO       = nota.pesoB;
                    var F2_HORA         = "SUBSTRING(CONVERT(VARCHAR(20), GETDATE(), 108), 1, 5)";
                    var F2_RECFAUT      = "1";
                    var F2_CHVNFE       = "'" + nota.ChaveNfe + "'";
                    query += "INSERT INTO SF2" + nota.CodEmpErp + "0(F2_FILIAL, F2_DOC, F2_SERIE, F2_CLIENTE, F2_CLIENT, F2_LOJA, F2_LOJENT, F2_COND, F2_DUPL, F2_EMISSAO, F2_EST, F2_FRETE, F2_DESPESA, ";
                    query += "F2_BASEICM,F2_VALICM,F2_BASEIPI,F2_VALIPI,F2_VALMERC,F2_VALBRUT,F2_TIPO,F2_DESCONT,F2_DTDIGIT,F2_CONTSOC,F2_ESPECIE,F2_BASIMP5,";
                    query += "F2_BASIMP6,F2_VALIMP5,F2_VALIMP6,F2_SEGURO,F2_MOEDA,F2_PREFIXO,F2_RECISS,R_E_C_N_O_,F2_ICMFRET,F2_TIPOCLI,F2_VOLUME1,F2_VOLUME2,F2_VOLUME3,F2_VOLUME4,";
                    query += "F2_ICMSRET,F2_PLIQUI, F2_PBRUTO,F2_HORA,F2_RECFAUT,F2_CHVNFE) ";
                    query += "VALUES (";
                    query += F2_FILIAL + F2_DOC + F2_SERIE + F2_CLIENTE + F2_CLIENT + F2_LOJA + F2_LOJENT + F2_COND + F2_DUPL + F2_EMISSAO + F2_EST + F2_FRETE + F2_DESPESA + F2_BASEICM + F2_VALICM + F2_BASEIPI + F2_VALIPI + F2_VALMERC + F2_VALBRUT + F2_TIPO + F2_DESCONT + F2_DTDIGIT + F2_CONTSOC + F2_ESPECIE + F2_BASIMP5 + F2_BASIMP6 + F2_VALIMP5 + F2_VALIMP6 + F2_SEGURO + F2_MOEDA + F2_PREFIXO + F2_RECISS + R_E_C_N_O_ + F2_ICMFRET + F2_TIPOCLI + F2_VOLUME1 + F2_VOLUME2 + F2_VOLUME3 + F2_VOLUME4 + F2_ICMSRET + F2_PLIQUI + F2_PBRUTO + F2_HORA + F2_RECFAUT + F2_CHVNFE;
                    query += ")";
                }



            }
            return query;
        }

        public static string sqlCodTransp(string tipoErp, string CodEmpErp, string cnpjTransp)
        {
            string query = "";
            if (tipoErp.ToLower() == "protheus")
            {
                query = "SELECT A4_COD FROM SA4" + CodEmpErp + "0 WHERE A4_CGC = '" + cnpjTransp + "' AND D_E_L_E_T_ <> '*'";
            }
            else
            {
                query = "query rm";
            }
            
            return query;
        }

        //SA4	CADASTRO DE TRANSPORTADORAS
        public static string sqlInsereTransp(string tipoErp, string codTransp, XmlNfe nota)
        {
            string query = "";
            if (tipoErp.ToLower() == "protheus")
            {
                var A4_COD = codTransp;
                var A4_NOME = nota.nomeTransportadora.Substring(0, 40);
                var A4_NREDUZ = nota.nomeTransportadora.Substring(0, 15);
                var A4_END = nota.enderecoTransportadora;
                var A4_MUN = nota.municipioTransportadora;
                var A4_EST = nota.ufTransportadora;
                var A4_CGC = nota.CnpjTransportadora;
                var A4_INSEST = nota.ieTransportadora;
                query += "INSERT INTO SA4" + nota.CodEmpErp + "0 (A4_COD,A4_NOME,A4_NREDUZ,A4_END,A4_MUN,A4_EST,A4_CGC,A4_INSEST) ";
                query += " VALUES(";
                query += A4_COD + A4_NOME + A4_NREDUZ + A4_END + A4_MUN + A4_EST + A4_CGC + A4_INSEST;
                query += ");";
            }
            return query;
        }

        //SC5	PEDIDOS DE VENDA
        public static string[] sqlInserePedidoVenda(string tipoErp, XmlNfe nota)
        {
            //Esta função retorna um array, pois deve retornar o C5_NUM para ser utilizado nos itens
            string[] query = new string[2];
            query[0] = "";
            if (tipoErp.ToLower() == "protheus")
            {
                var C5_FILIAL   = "'" + nota.CodFilErp + "',";
                var C5_NUM      = "ISNULL((SELECT REPLICATE('0', 6-LEN(MAX(C5_NUM)+1))+CAST(MAX(C5_NUM)+1 AS VARCHAR(6)) FROM SC5" + nota.CodEmpErp + "0 WHERE C5_FILIAL = '" + nota.CodFilErp + "'), '000001'),";
                //Valor atribuido para ser utilizado nos itens
                query[1]        = C5_NUM;
                var C5_TIPO     = "'N',";
                var C5_CLIENTE  = "'" + nota.CodCliForErp;
                var C5_CLIENT   = "'" + nota.CodCliForErp;
                var C5_LOJACLI  = "'" + nota.CodLojaCliForErp;
                var C5_LOJAENT  = "'" + nota.CodLojaCliForErp;
                var C5_TIPOCLI  = "'" + nota.TipoCli;
                var C5_CONDPAG  = "'" + nota.CodCondPagto;
                var C5_EMISSAO  = "REPLACE(CAST(CAST('" + nota.DataEmissao + "' AS DATE) AS VARCHAR(20)), '-', ''),";
                var C5_FRETE    = "'" + nota.vFrete;
                var C5_SEGURO   = "'" + nota.vSeg;
                var C5_DESPESA  = "'" + nota.vOutro;
                var C5_MOEDA    = "'1',";
                var C5_PESOL    = "'" + nota.pesoL;
                var C5_PBRUTO   = "'" + nota.pesoB;
                var C5_LIBEROK  = "'S',";
                var C5_NOTA     = "'" + nota.NumNf;
                var C5_SERIE    = "'" + nota.serieNf;
                var C5_TIPLIB   = "'1',";
                var C5_DESCONT  = "'" + nota.vDesc;
                var C5_TXMOEDA  = "'1',";
                var C5_TPCARGA  = "'2',";
                var C5_GERAWMS  = "'1',";
                var C5_SOLOPC   = "'1',";
                var R_E_C_N_O_ = "(SELECT MAX(R_E_C_N_O_)+1 FROM SC5" + nota.CodEmpErp + "0)";
                var R_E_C_D_E_L_ = "'0'";
                query[0] += "INSERT INTO SC5" + nota.CodEmpErp + "0(C5_FILIAL, C5_NUM, C5_TIPO, C5_CLIENTE, C5_CLIENT, C5_LOJACLI, C5_LOJAENT, C5_TIPOCLI, C5_CONDPAG, C5_EMISSAO, C5_FRETE, C5_SEGURO, C5_DESPESA, C5_MOEDA,C5_PESOL,C5_PBRUTO,C5_LIBEROK,C5_NOTA,C5_SERIE,C5_TIPLIB,C5_DESCONT,C5_TXMOEDA,C5_TPCARGA,C5_GERAWMS,C5_SOLOPC,R_E_C_N_O_,R_E_C_D_E_L_) ";
                query[0] += "VALUES (";
                query[0] += C5_FILIAL + C5_NUM + C5_TIPO + C5_CLIENTE + C5_CLIENT + C5_LOJACLI + C5_LOJAENT + C5_TIPOCLI + C5_CONDPAG + C5_EMISSAO + C5_FRETE + C5_SEGURO + C5_DESPESA + C5_MOEDA + C5_PESOL + C5_PBRUTO + C5_LIBEROK + C5_NOTA + C5_SERIE + C5_TIPLIB + C5_DESCONT + C5_TXMOEDA + C5_TPCARGA + C5_GERAWMS + C5_SOLOPC + R_E_C_N_O_ + R_E_C_D_E_L_;
                query[0] += ");";
            }
            else
            {
                //Implementar RM
            }
            return query;
        }

        //SC6	ITENS DOS PEDIDOS DE VENDA
        public static string sqlInsereItensPedidoVenda(XmlNfe nota, ProdutosNfe dadosProd, string C5Num = "")
        {
            string query = "";
            if (nota.tipoErp.ToLower() == "protheus")
            {
                var C6_FILIAL   = nota.CodFilErp;
                var C6_ITEM     = dadosProd.numItem;
                var C6_PRODUTO  = dadosProd.codProdErp;
                var C6_UM       = dadosProd.uCom;
                var C6_QTDVEN   = dadosProd.qCom;
                var C6_PRCVEN   = dadosProd.vUnCom;
                var C6_VALOR    = dadosProd.vProd;
                var C6_TES      = dadosProd.TES;
                var C6_LOCAL    = "01";
                var C6_CF       = dadosProd.CFOP;
                var C6_QTDENT   = dadosProd.qCom;
                var C6_CLI      = nota.CodCliForErp;
                var C6_ENTREG   = "REPLACE(CAST(CAST('" + nota.DataEmissao + "' AS DATE) AS VARCHAR(20)), '-', ''),";
                var C6_LOJA     = nota.CodLojaCliForErp;
                var C6_NOTA     = nota.NumNf;
                var C6_SERIE    = nota.serieNf;
                var C6_DATFAT   = "REPLACE(CAST(CAST('" + nota.DataEmissao + "' AS DATE) AS VARCHAR(20)), '-', ''),";
                var C6_NUM      = C5Num;
                var C6_DESCRI   = dadosProd.vDesc;
                var C6_PRUNIT   = dadosProd.vUnCom;
                //Implementar ICMS
                var C6_CLASFIS  = "";
                var C6_TPOP     = "'F',";
                var C6_SUGENTR  = "REPLACE(CAST(CAST('" + nota.DataEmissao + "' AS DATE) AS VARCHAR(20)), '-', ''),";
                var C6_RATEIO   = "'2',";
                var R_E_C_N_O_  = "(SELECT MAX(R_E_C_N_O_) + 1 FROM SC6" + nota.CodEmpErp + "0)";
                var R_E_C_D_E_L_ = "'0'";

                query += "INSERT INTO SC6" + nota.CodEmpErp + "(C6_FILIAL,C6_ITEM,C6_PRODUTO,C6_UM,C6_QTDVEN,C6_PRCVEN,C6_VALOR,C6_TES,C6_LOCAL,C6_CF,C6_QTDENT,C6_CLI,C6_ENTREG,C6_LOJA,C6_NOTA,C6_SERIE,C6_DATFAT,C6_NUM,C6_DESCRI,C6_PRUNIT,C6_CLASFIS,C6_TPOP,C6_SUGENTR,C6_RATEIO,R_E_C_N_O_,R_E_C_D_E_L_) ";
                query += " VALUES(";
                query += C6_FILIAL + C6_ITEM + C6_PRODUTO + C6_UM + C6_QTDVEN + C6_PRCVEN + C6_VALOR + C6_TES + C6_LOCAL + C6_CF + C6_QTDENT + C6_CLI + C6_ENTREG + C6_LOJA + C6_NOTA + C6_SERIE + C6_DATFAT + C6_NUM + C6_DESCRI + C6_PRUNIT + C6_CLASFIS + C6_TPOP + C6_SUGENTR + C6_RATEIO + R_E_C_N_O_ + R_E_C_D_E_L_;
                query += ");";
            }
            return query;
        }

        //SC9	PEDIDOS LIBERADOS
        public static string sqlInserePedidoLiberado(XmlNfe nota, ProdutosNfe dadosProd, string C5Num = "")
        {
            string query = "";
            if (nota.tipoErp.ToLower() == "protheus")
            {
                var C9_OK       = "    ";
                var C9_FILIAL   = nota.CodFilErp;
                var C9_PEDIDO   = C5Num;
                var C9_ITEM     = dadosProd.numItem;
                var C9_CLIENTE  = nota.CodCliForErp;
                var C9_LOJA     = nota.CodLojaCliForErp;
                var C9_PRODUTO  = dadosProd.codProdErp;
                var C9_QTDLIB   = dadosProd.qCom;
                var C9_NFISCAL  = nota.NumNf;
                var C9_SERIENF  = nota.serieNf;
                var C9_DATALIB  = "REPLACE(CAST(CAST('" + nota.DataEmissao + "' AS DATE) AS VARCHAR(20)), '-', ''),";
                var C9_SEQUEN   = "'01',";
                var C9_PRCVEN   = "'" + dadosProd.vUnCom;
                var C9_BLEST    = "'10',";
                var C9_BLCRED   = "'10',";
                var C9_LOCAL    = "'01',";
                var C9_TPCARGA  = "'2',";
                var C9_NUMSEQ   = "(SELECT REPLICATE('0', 6-LEN(MAX(C9_NUMSEQ)+1))+CAST(MAX(C9_NUMSEQ)+1 AS VARCHAR(6)) FROM SC9" + nota.CodEmpErp + "),";
                var C9_RETOPER  = "'2',";
                var R_E_C_N_O_  = "(SELECT MAX(R_E_C_N_O_)+1 FROM SC9" + nota.CodEmpErp + "),";
                var R_E_C_D_E_L_ = "'0'";
                query += "INSERT INTO SC9" + nota.CodEmpErp + "0 (C9_OK,C9_FILIAL,C9_PEDIDO,C9_ITEM,C9_CLIENTE,C9_LOJA,C9_PRODUTO,C9_QTDLIB,C9_NFISCAL,C9_SERIENF,C9_DATALIB,C9_SEQUEN,C9_PRCVEN,C9_BLEST,C9_BLCRED,C9_LOCAL,C9_TPCARGA,C9_NUMSEQ,C9_RETOPER,R_E_C_N_O_,R_E_C_D_E_L_) ";
                query += " VALUES(";
                query += C9_OK + C9_FILIAL + C9_PEDIDO + C9_ITEM + C9_CLIENTE + C9_LOJA + C9_PRODUTO + C9_QTDLIB + C9_NFISCAL + C9_SERIENF + C9_DATALIB + C9_SEQUEN + C9_PRCVEN + C9_BLEST + C9_BLCRED + C9_LOCAL + C9_TPCARGA + C9_NUMSEQ + C9_RETOPER + R_E_C_N_O_ + R_E_C_D_E_L_;
                query += ")";
            }
            return query;
        }

        public static void movePara(string nomeArquivo, string pastaDestino)
        {
            //Move o arquivo para a pasta de criticados
            if (File.Exists(pastaDestino + "\\" + System.IO.Path.GetFileName(nomeArquivo)))
            {
                File.Delete(pastaDestino + "\\" + System.IO.Path.GetFileName(nomeArquivo));
            }
            File.Move(nomeArquivo, pastaDestino + "\\" + System.IO.Path.GetFileName(nomeArquivo));
        }

        //Insere Log
        public static string sqlInsereLog(string nomeArquivo, string msg, string CST = "", string PICM = "")
        {
            return "INSERT INTO LOGEVENTOSXML (NOME_XML, DATAEMISSAO, SETOR, USUARIO, EVENTO, CRITICA, CST) " +
                      "VALUES ('" + nomeArquivo + "',GETDATE(), 'FIS', 'inspetorXml', 'I', '"+ msg +"', '"+ CST +"');";

        }

        public static string sqlGrupoTrib(string codTab, string codProduto, string codFilial)
        {
            return "SELECT B1_GRTRIB FROM SB1" + codTab + "0 WHERE B1_COD = '" + codProduto + "' AND B1_FILIAL = '" + codFilial + "' AND D_E_L_E_T_ <> '*'";
        }

        //Pauta
        public static string sqlPauta(string codTab, string UF, string codFilial, string GrpTrib)
        {
            return "SELECT F7_MARGEM, F7_VLR_ICM, F7_VLRICMP FROM SF7" + codTab + "0 WHERE F7_GRTRIB = '" + GrpTrib + "' AND F7_FILIAL = '" + sFilialEmitDest + "' AND F7_EST = '" + UF + "' AND D_E_L_E_T_ <> '*'";
        }

        public static string sqlRegrasCst()
        {
            return "SELECT CONTEUDO, ORDEM FROM REGRASXML WHERE PROCESSO = 'CST' ORDER BY ORDEM";
        }
    }
}
