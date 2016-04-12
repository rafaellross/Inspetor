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

        public static string sqlCliForErp(string tipoErp, string tipoNf, string cnpjCliFor, string codTab = "", string codFilial = "", string nomeCliFor = "", bool Exportacao = false)
        {
            if (tipoErp.ToLower() == "protheus")
            {
                if (tipoNf == "ENTRADA")
                {
                    return "SELECT A2_COD, A2_LOJA, A2_MSBLQL, A2_COND, A2_TIPO FROM SA2" + codTab + "0 WHERE REPLACE(REPLACE(REPLACE(A2_CGC, '.', ''), '/', ''), '-', '') = '" + cnpjCliFor + "' AND D_E_L_E_T_ <> '*' AND A2_FILIAL = '" + codFilial + "';";
                }
                else if (tipoNf == "ENT_IMP")
                {
                    return "SELECT A2_COD, A2_LOJA, A2_MSBLQL, A2_COND, A2_TIPO FROM SA2" + codTab + "0 WHERE  A2_NOME = SUBSTRING('" + nomeCliFor + "', 1, 40) AND D_E_L_E_T_ <> '*' AND A2_FILIAL = '" + codFilial + "';";
                }
                else if (tipoNf == "SAIDA" && Exportacao)
                {
                    return "SELECT A1_COD, A1_LOJA, A1_MSBLQL, A1_COND, A1_TIPO FROM SA1" + codTab + "0 WHERE A1_NOME = SUBSTRING('" + nomeCliFor + "', 1, 40) AND D_E_L_E_T_ <> '*'";
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

        public static string sqlInsertCliFor(string tipoErp, XmlNfe nota)
        {
            var query = "";
            if (nota.TipoNf == "SAIDA")
            {
                var A1_FILIAL   = "'" + nota.CodFilErp + "',";
                var A1_COD      = "ISNULL((SELECT REPLICATE('0', 6-LEN(CAST(MAX(A1_COD)+1 AS VARCHAR(6)))) + CAST(MAX(A1_COD)+1 AS VARCHAR(6)) FROM " + nota.TabSA1 + " WHERE A1_FILIAL =  '"+ nota.CodFilErp +"' and PATINDEX('%[A-Z]%', A1_COD) = 0), '000001'),";
                var A1_LOJA     = "'" + (nota.TipoPessoa == "F" ? "01" : nota.CnpjDestinatario.Substring(10, 2)) + "',";
                var A1_PESSOA   = "'" + nota.TipoPessoa + "',";
                var A1_NOME     = "SUBSTRING('" + nota.NomeDestinatario + "', 1, 40),";
                var A1_NREDUZ   = "SUBSTRING('" + nota.NomeDestinatario + "', 1, 20),";
                var A1_END      = "SUBSTRING('" + nota.enderecoDestinatario + "', 1, 40),";
                var A1_TIPO = "'',"; 
                if (nota.TipoPessoa == "F" || nota.ieDestinatario == "")
                {
                    A1_TIPO = "'F',"; 
                }
                else
                {
                    A1_TIPO = "'S',";
                }
                
                var A1_EST      = "'" + nota.UFDestinatario + "',";
                var A1_ESTADO   = "'',";
                var A1_COD_MUN  = "SUBSTRING('" + nota.codMunicipioDestinatario + "', 3, 5),";
                var A1_MUN      = "'" + nota.nomeMunicipioDestinatario + "',";
                var A1_BAIRRO   = "'" + nota.bairroDestinatario + "', ";
                var A1_NATUREZ = "'',"; 
                if (nota.paisDestinatario != "1058")
                {
                    A1_NATUREZ = "'0061',";
                }
                else
                {
                    A1_NATUREZ = "'0060',";
                }
                
                var A1_IBGE     = "'',";
                var A1_CEP      = "'" + nota.cepDestinatario + "',";
                var A1_DDI      = "'',";
                var A1_DDD      = "'',";
                var A1_TEL      = "'" + nota.telefoneDestinatario + "',";
                var A1_TELEX    = "'',";
                var A1_FAX      = "'',";
                var A1_ENDCOB   = "'',";
                var A1_PAIS     = "'',";
                var A1_ENDREC   = "'',";
                var A1_ENDENT   = "'',";
                var A1_TRIBFAV  = "'',";
                var A1_CONTATO  = "'',";
                var A1_CGC      = "'" + nota.CnpjDestinatario + "',";
                var A1_PFISICA  = "'',";
                var A1_INSCR    = "'" + nota.ieDestinatario + "',";
                var A1_INSCRM   = "'',";
                var A1_VEND     = "'',";
                var A1_COMIS    = "'0',";
                var A1_REGIAO   = "'',";
                var A1_CONTA = "'',"; //Perguntar ao Mori;
                if (nota.paisDestinatario != "1058")
                {
                    A1_CONTA = "'112010061',";
                }
                else
                {
                    A1_CONTA = "'112010060',";
                }
                
                var A1_BCO1     = "'',";
                var A1_BCO2     = "'',";
                var A1_BCO3     = "'',";
                var A1_BCO4     = "'',";
                var A1_BCO5     = "'',";
                var A1_TRANSP   = "'',";
                var A1_TPFRET   = "'',";
                var A1_COND     = "'001',"; //Perguntar ao Mori;
                var A1_DESC     = "'',";
                var A1_PRIOR    = "'',";
                var A1_RISCO    = "'',";
                var A1_LC       = "'0',"; 
                var A1_VENCLC   = "'',";
                var A1_CLASSE   = "'',";
                var A1_LCFIN    = "'0',";
                var A1_MOEDALC  = "'2',";
                var A1_MSALDO   = "'0',";
                var A1_MCOMPRA  = "'0',";
                var A1_METR     = "'0',";
                var A1_PRICOM   = "'',";
                var A1_ULTCOM   = "'',";
                var A1_NROCOM   = "'1',";
                var A1_FORMVIS  = "'',";
                var A1_TEMVIS   = "'0',";
                var A1_ULTVIS   = "'',";
                var A1_TMPVIS   = "'00:00',";
                var A1_CLASVEN  = "'',";
                var A1_TMPSTD   = "'00:00',";
                var A1_MENSAGE = "'',";
                var A1_SALDUP = "'0',";
                var A1_RECISS = "'2',";
                var A1_NROPAG = "'0',";
                var A1_SALPEDL = "'0',";
                var A1_TRANSF = "'',";
                var A1_SUFRAMA = "'',";
                var A1_ATR = "'0',";
                var A1_VACUM = "'0',";
                var A1_SALPED = "'0',";
                var A1_TITPROT = "'0',";
                var A1_CHQDEVO = "'0',";
                var A1_DTULTIT = "'',";
                var A1_MATR = "'0',";
                var A1_DTULCHQ = "'',";
                var A1_MAIDUPL = "'0',";
                var A1_TABELA = "'',";
                var A1_INCISS = "'',";
                var A1_SALDUPM = "'0',";
                var A1_PAGATR = "'0',";
                var A1_CXPOSTA = "'',";
                var A1_ATIVIDA = "'',";
                var A1_CARGO1 = "'',";
                var A1_CARGO2 = "'',";
                var A1_CARGO3 = "'',";
                var A1_RTEC = "'',";
                var A1_SUPER = "'',";
                var A1_ALIQIR = "'1.5',";
                var A1_OBSERV = "'',";
                var A1_RG = "'',";
                var A1_CALCSUF = "'',";
                var A1_DTNASC = "'',";
                var A1_SALPEDB = "'0',";
                var A1_CLIFAT = "'',";
                var A1_GRPTRIB = "'',";
                var A1_BAIRROC = "'',";
                var A1_CEPC = "'',";
                var A1_MUNC = "'',";
                var A1_ESTC = "'',";
                var A1_CEPE = "'',";
                var A1_BAIRROE = "'',";
                var A1_MUNE = "'',";
                var A1_ESTE = "'',";
                var A1_SATIV1 = "'',";
                var A1_SATIV2 = "'',";
                var A1_TPISSRS = "'',";
                var A1_CODLOC = "'',";
                var A1_TPESSOA = "'',";
                var A1_CODPAIS = "'" + nota.paisDestinatario +"',";
                var A1_SATIV3 = "'',";
                var A1_SATIV4 = "'',";
                var A1_SATIV5 = "'',";
                var A1_SATIV6 = "'',";
                var A1_SATIV7 = "'',";
                var A1_SATIV8 = "'',";
                var A1_CODMARC = "'',";
                var A1_CODAGE = "'',";
                var A1_COMAGE = "'0',";
                var A1_TIPCLI = "'',";
                var A1_DEST_1 = "'',";
                var A1_EMAIL = "'',";
                var A1_DEST_2 = "'',";
                var A1_CODMUN = "'',";
                var A1_DEST_3 = "'',";
                var A1_HPAGE = "'',";
                var A1_CBO = "'',";
                var A1_CNAE = "'',";
                var A1_CONDPAG = "'',"; //Perguntar ao Mori
                var A1_DIASPAG = "'',";
                var A1_OBS = "'',";
                var A1_AGREG = "'',";
                var A1_CODHIST = "'',";
                var A1_RECINSS = "'',";
                var A1_RECCOFI = "'',";
                var A1_RECCSLL = "'',";
                var A1_RECPIS = "'',";
                var A1_TIPPER = "'',";
                var A1_SALFIN = "'0',";
                var A1_SALFINM = "'0',";
                var A1_CONTAB = "'',";
                var A1_B2B = "'',";
                var A1_GRPVEN = "'',";
                var A1_CLICNV = "'',";
                var A1_INSCRUR = "'',";
                var A1_MSBLQL = "'2',";
                var A1_SITUA = "'',";
                var A1_NUMRA = "'',";
                var A1_SUBCOD = "'',";
                var A1_CDRDES = "'',";
                var A1_FILDEB = "'',";
                var A1_CODFOR = "'',";
                var A1_ABICS = "'',";
                var A1_BLEMAIL = "'',";
                var A1_TIPOCLI = "'',";
                var A1_VINCULO = "'',";
                var A1_DTINIV = "'',";
                var A1_DTFIMV = "'',";
                var A1_LOCCONS = "'',";
                var A1_CBAIRRE = "'',";
                var A1_CODMUNE = "'',";
                var A1_PERFIL = "'0',";
                var A1_HRTRANS = "'',";
                var A1_UNIDVEN = "'',";
                var A1_TIPPRFL = "'',";
                var A1_PRF_VLD = "'',";
                var A1_PRF_COD = "'',";
                var A1_PRF_OBS = "null,";
                var A1_REGPB = "'',";
                var A1_USADDA = "'',";
                var A1_SIMPLES = "'',";
                var A1_CTARE = "'',";
                var A1_FRETISS = "'',";
                var A1_CODSIAF = "'',";
                var A1_ENDNOT = "'',";
                var A1_CEINSS = "'',";
                var A1_REGESIM = "'',";
                var A1_PERCATM = "'0',";
                var A1_IPWEB = "'',";
                var A1_IDHIST = "'',";
                var A1_INDRET = "'',";
                var A1_NIF = "'',";
                var A1_IRBAX = "'',";
                var A1_ABATIMP = "'',";
                var A1_CONTRIB = "'',";
                if (A1_TIPO == "'F',")
                {
                    A1_CONTRIB = "'2',";
                }
                var A1_TDA = "'',";
                var A1_COMPLEM = "'',";
                var A1_TIMEKEE = "'',";
                var A1_RECIRRF = "'',";
                var A1_ORIGEM = "'',";
                var A1_FOMEZER = "'',";
                var A1_RECFET = "'',";
                var A1_INCULT = "'',";
                var A1_MINIRF = "'',";
                var A1_FILTRF = "'',";
                var A1_MATFUN = "'',";
                var A1_OUTRMUN = "'',";
                var A1_CODFID = "'',";
                var A1_SIMPNAC = "'',";
                var A1_TPNFSE = "'',";
                var A1_ALIFIXA = "'',";
                var A1_CRDMA = "'',";
                var A1_PRSTSER = "'',";
                var A1_RFACS = "'',";
                var A1_RFABOV = "'',";
                var A1_PERFECP = "'0',";
                var A1_IENCONT = "'',";
                var A1_TPDP = "'',";
                var A1_ENTID = "'',";
                var A1_TPJ = "'',";
                var A1_INOVAUT = "'',";
                var A1_NR_END = "'',";
                var A1_ENDCOMP = "'',";
                var A1_RECFMD = "'',";
                var D_E_L_E_T_ = "'',";
                var R_E_C_N_O_ = "ISNULL((SELECT MAX(R_E_C_N_O_)+1 FROM " + nota.TabSA1 + "), 1),";
                var R_E_C_D_E_L_ = "'0',";
                var A1_INCLTMG = "''";
                
                query += "INSERT INTO " + nota.TabSA1 + "(A1_FILIAL, A1_COD, A1_LOJA, A1_PESSOA, A1_NOME, A1_NREDUZ, A1_END, A1_TIPO, A1_EST, A1_ESTADO, A1_COD_MUN, A1_MUN, A1_BAIRRO, A1_NATUREZ, A1_IBGE, A1_CEP, A1_DDI, A1_DDD, A1_TEL, A1_TELEX, A1_FAX, A1_ENDCOB, A1_PAIS, A1_ENDREC, A1_ENDENT, A1_TRIBFAV, A1_CONTATO, A1_CGC, A1_PFISICA, A1_INSCR, A1_INSCRM, A1_VEND, A1_COMIS, A1_REGIAO, A1_CONTA, A1_BCO1, A1_BCO2, A1_BCO3, A1_BCO4, A1_BCO5, A1_TRANSP, A1_TPFRET, A1_COND, A1_DESC, A1_PRIOR, A1_RISCO, A1_LC, A1_VENCLC, A1_CLASSE, A1_LCFIN, A1_MOEDALC, A1_MSALDO, A1_MCOMPRA, A1_METR, A1_PRICOM, A1_ULTCOM, A1_NROCOM, A1_FORMVIS, A1_TEMVIS, A1_ULTVIS, A1_TMPVIS, A1_CLASVEN, A1_TMPSTD, A1_MENSAGE, A1_SALDUP, A1_RECISS, A1_NROPAG, A1_SALPEDL, A1_TRANSF, A1_SUFRAMA, A1_ATR, A1_VACUM, A1_SALPED, A1_TITPROT, A1_CHQDEVO, A1_DTULTIT, A1_MATR, A1_DTULCHQ, A1_MAIDUPL, A1_TABELA, A1_INCISS, A1_SALDUPM, A1_PAGATR, A1_CXPOSTA, A1_ATIVIDA, A1_CARGO1, A1_CARGO2, A1_CARGO3, A1_RTEC, A1_SUPER, A1_ALIQIR, A1_OBSERV, A1_RG, A1_CALCSUF, A1_DTNASC, A1_SALPEDB, A1_CLIFAT, A1_GRPTRIB, A1_BAIRROC, A1_CEPC, A1_MUNC, A1_ESTC, A1_CEPE, A1_BAIRROE, A1_MUNE, A1_ESTE, A1_SATIV1, A1_SATIV2, A1_TPISSRS, A1_CODLOC, A1_TPESSOA, A1_CODPAIS, A1_SATIV3, A1_SATIV4, A1_SATIV5, A1_SATIV6, A1_SATIV7, A1_SATIV8, A1_CODMARC, A1_CODAGE, A1_COMAGE, A1_TIPCLI, A1_DEST_1, A1_EMAIL, A1_DEST_2, A1_CODMUN, A1_DEST_3, A1_HPAGE, A1_CBO, A1_CNAE, A1_CONDPAG, A1_DIASPAG, A1_OBS, A1_AGREG, A1_CODHIST, A1_RECINSS, A1_RECCOFI, A1_RECCSLL, A1_RECPIS, A1_TIPPER, A1_SALFIN, A1_SALFINM, A1_CONTAB, A1_B2B, A1_GRPVEN, A1_CLICNV, A1_INSCRUR, A1_MSBLQL, A1_SITUA, A1_NUMRA, A1_SUBCOD, A1_CDRDES, A1_FILDEB, A1_CODFOR, A1_ABICS, A1_BLEMAIL, A1_TIPOCLI, A1_VINCULO, A1_DTINIV, A1_DTFIMV, A1_LOCCONS, A1_CBAIRRE, A1_CODMUNE, A1_PERFIL, A1_HRTRANS, A1_UNIDVEN, A1_TIPPRFL, A1_PRF_VLD, A1_PRF_COD, A1_PRF_OBS, A1_REGPB, A1_USADDA, A1_SIMPLES, A1_CTARE, A1_FRETISS, A1_CODSIAF, A1_ENDNOT, A1_CEINSS, A1_REGESIM, A1_PERCATM, A1_IPWEB, A1_IDHIST, A1_INDRET, A1_NIF, A1_IRBAX, A1_ABATIMP, A1_CONTRIB, A1_TDA, A1_COMPLEM, A1_TIMEKEE, A1_RECIRRF, A1_ORIGEM, A1_FOMEZER, A1_RECFET, A1_INCULT, A1_MINIRF, A1_FILTRF, A1_MATFUN, A1_OUTRMUN, A1_CODFID, A1_SIMPNAC, A1_TPNFSE, A1_ALIFIXA, A1_CRDMA, A1_PRSTSER, A1_RFACS, A1_RFABOV, A1_PERFECP, A1_IENCONT, A1_TPDP, A1_ENTID, A1_TPJ, A1_INOVAUT, /*A1_NR_END,A1_ENDCOMP, */ A1_RECFMD, D_E_L_E_T_, R_E_C_N_O_, R_E_C_D_E_L_, A1_INCLTMG) ";
                query += "VALUES(";
                query += A1_FILIAL + A1_COD + A1_LOJA + A1_PESSOA + A1_NOME + A1_NREDUZ + A1_END + A1_TIPO + A1_EST + A1_ESTADO + A1_COD_MUN + A1_MUN + A1_BAIRRO + A1_NATUREZ + A1_IBGE + A1_CEP + A1_DDI + A1_DDD + A1_TEL + A1_TELEX + A1_FAX + A1_ENDCOB + A1_PAIS + A1_ENDREC + A1_ENDENT + A1_TRIBFAV + A1_CONTATO + A1_CGC + A1_PFISICA + A1_INSCR + A1_INSCRM + A1_VEND + A1_COMIS + A1_REGIAO + A1_CONTA + A1_BCO1 + A1_BCO2 + A1_BCO3 + A1_BCO4 + A1_BCO5 + A1_TRANSP + A1_TPFRET + A1_COND + A1_DESC + A1_PRIOR + A1_RISCO + A1_LC + A1_VENCLC + A1_CLASSE + A1_LCFIN + A1_MOEDALC + A1_MSALDO + A1_MCOMPRA + A1_METR + A1_PRICOM + A1_ULTCOM + A1_NROCOM + A1_FORMVIS + A1_TEMVIS + A1_ULTVIS + A1_TMPVIS + A1_CLASVEN + A1_TMPSTD + A1_MENSAGE + A1_SALDUP + A1_RECISS + A1_NROPAG + A1_SALPEDL + A1_TRANSF + A1_SUFRAMA + A1_ATR + A1_VACUM + A1_SALPED + A1_TITPROT + A1_CHQDEVO + A1_DTULTIT + A1_MATR + A1_DTULCHQ + A1_MAIDUPL + A1_TABELA + A1_INCISS + A1_SALDUPM + A1_PAGATR + A1_CXPOSTA + A1_ATIVIDA + A1_CARGO1 + A1_CARGO2 + A1_CARGO3 + A1_RTEC + A1_SUPER + A1_ALIQIR + A1_OBSERV + A1_RG + A1_CALCSUF + A1_DTNASC + A1_SALPEDB + A1_CLIFAT + A1_GRPTRIB + A1_BAIRROC + A1_CEPC + A1_MUNC + A1_ESTC + A1_CEPE + A1_BAIRROE + A1_MUNE + A1_ESTE + A1_SATIV1 + A1_SATIV2 + A1_TPISSRS + A1_CODLOC + A1_TPESSOA + A1_CODPAIS + A1_SATIV3 + A1_SATIV4 + A1_SATIV5 + A1_SATIV6 + A1_SATIV7 + A1_SATIV8 + A1_CODMARC + A1_CODAGE + A1_COMAGE + A1_TIPCLI + A1_DEST_1 + A1_EMAIL + A1_DEST_2 + A1_CODMUN + A1_DEST_3 + A1_HPAGE + A1_CBO + A1_CNAE + A1_CONDPAG + A1_DIASPAG + A1_OBS + A1_AGREG + A1_CODHIST + A1_RECINSS + A1_RECCOFI + A1_RECCSLL + A1_RECPIS + A1_TIPPER + A1_SALFIN + A1_SALFINM + A1_CONTAB + A1_B2B + A1_GRPVEN + A1_CLICNV + A1_INSCRUR + A1_MSBLQL + A1_SITUA + A1_NUMRA + A1_SUBCOD + A1_CDRDES + A1_FILDEB + A1_CODFOR + A1_ABICS + A1_BLEMAIL + A1_TIPOCLI + A1_VINCULO + A1_DTINIV + A1_DTFIMV + A1_LOCCONS + A1_CBAIRRE + A1_CODMUNE + A1_PERFIL + A1_HRTRANS + A1_UNIDVEN + A1_TIPPRFL + A1_PRF_VLD + A1_PRF_COD + A1_PRF_OBS + A1_REGPB + A1_USADDA + A1_SIMPLES + A1_CTARE + A1_FRETISS + A1_CODSIAF + A1_ENDNOT + A1_CEINSS + A1_REGESIM + A1_PERCATM + A1_IPWEB + A1_IDHIST + A1_INDRET + A1_NIF + A1_IRBAX + A1_ABATIMP + A1_CONTRIB + A1_TDA + A1_COMPLEM + A1_TIMEKEE + A1_RECIRRF + A1_ORIGEM + A1_FOMEZER + A1_RECFET + A1_INCULT + A1_MINIRF + A1_FILTRF + A1_MATFUN + A1_OUTRMUN + A1_CODFID + A1_SIMPNAC + A1_TPNFSE + A1_ALIFIXA + A1_CRDMA + A1_PRSTSER + A1_RFACS + A1_RFABOV + A1_PERFECP + A1_IENCONT + A1_TPDP + A1_ENTID + A1_TPJ + A1_INOVAUT + /*A1_NR_END + A1_ENDCOMP + */ A1_RECFMD + D_E_L_E_T_ + R_E_C_N_O_ + R_E_C_D_E_L_ + A1_INCLTMG;
                query += ");";
            }
            else
            {
                var A2_FILIAL   = "'" + nota.CodFilErp + "',";
                var A2_COD      = "ISNULL((SELECT REPLICATE('0', 6-LEN(CAST(MAX(A2_COD)+1 AS VARCHAR(6)))) + CAST(MAX(A2_COD)+1 AS VARCHAR(6)) FROM " + nota.TabSA1 + " WHERE A1_FILIAL =  '" + nota.CodFilErp + "' AND PATINDEX('%[A-Z]%', A2_COD) = 0), '000001'),";
                var A2_LOJA     = "'" + nota.CnpjEmitente.Substring(10, 2) + "',";
                var A2_NOME     = "SUBSTRING('" + nota.NomeEmitente + "', 1, 40),";
                var A2_NREDUZ   = "SUBSTRING('" + nota.NomeEmitente + "', 1, 20),";
                var A2_END      = "SUBSTRING('" + nota.enderecoEmitente + "', 1, 40),";
                var A2_NR_END   = "'" + nota.nroEnderecoEmitente + "',";
                var A2_BAIRRO   = "'" + nota.bairroEnderecoEmitente + "',";
                var A2_EST      = "'" + nota.UFEmitente + "',";
                var A2_CONTPRE  = "'1',"; //Perguntar ao Mori
                var A2_ESTADO   = "'',";
                var A2_COD_MUN  = "SUBSTRING('" + nota.codMunicipioEmitente + "', 3, 5),";
                var A2_MUN      = "'" + nota.municipioEmitente + "',";
                var A2_IBGE     = "'',";
                var A2_CEP      = "'" + nota.cepEmitente + "',";
                var A2_CX_POST  = "'',";
                var A2_TIPO     = "'J',";
                var A2_PFISICA  = "'',";
                var A2_CGC      = "'" + nota.CnpjEmitente + "',";
                var A2_DDI      = "'',";
                var A2_DDD      = "'',";
                var A2_TEL      = "'" + nota.telefoneEmitente + "',";
                var A2_FAX      = "'',";
                var A2_INSCR    = "'" + nota.ieEmitente + "',";
                var A2_INSCRM   = "'',";
                var A2_CONTATO  = "'',";
                var A2_BANCO    = "'',";
                var A2_AGENCIA  = "'',";
                var A2_NUMCON   = "'',";
                var A2_SWIFT    = "'',";
                var A2_NATUREZ  = "'',";
                var A2_TRANSP   = "'',";
                var A2_PRIOR    = "'',";
                var A2_RISCO    = "'',";
                var A2_COND     = "'001',";
                var A2_LC = "'',";
                var A2_MATR = "'0',";
                var A2_MCOMPRA = "'0',";
                var A2_METR = "'0',";
                var A2_MSALDO = "'0',";
                var A2_NROCOM = "'0',";
                var A2_PRICOM = "'',";
                var A2_ULTCOM = "'',";
                var A2_SALDUP = "'0',";
                var A2_DESVIO = "'0',";
                var A2_SALDUPM = "'0',";
                var A2_CONTA = "'',";
                var A2_TIPORUR = "'',";
                var A2_RECISS = "'',";
                var A2_PAIS = "'',";
                var A2_DEPTO = "'',";
                var A2_ID_FBFN = "'',";
                var A2_STATUS = "'',";
                var A2_GRUPO = "'',";
                var A2_ATIVIDA = "'',";
                var A2_ORIG_1 = "'',";
                var A2_ORIG_2 = "'',";
                var A2_ORIG_3 = "'',";
                var A2_VINCULA = "'',";
                var A2_REPRES = "'',";
                var A2_REPCONT = "'',";
                var A2_REPRTEL = "'',";
                var A2_REPRFAX = "'',";
                var A2_REPR_EM = "'',";
                var A2_REPR_EN = "'',";
                var A2_REPBAIR = "'',";
                var A2_REPRMUN = "'',";
                var A2_REPREST = "'',";
                var A2_REPRCEP = "'',";
                var A2_REPPAIS = "'',";
                var A2_ID_REPR = "'',";
                var A2_REPR_BA = "'',";
                var A2_REPR_AG = "'',";
                var A2_REPR_CO = "'',";
                var A2_REPRCGC = "'',";
                var A2_RET_PAI = "'',";
                var A2_COMI_SO = "'',";
                var A2_EMAIL = "'',";
                var A2_HPAGE = "'',";
                var A2_CODMUN = "'',";
                var A2_CONTCOM = "'',";
                var A2_FATAVA = "'0',";
                var A2_FABRICA = "'',";
                var A2_DTAVA = "'',";
                var A2_DTVAL = "'',";
                var A2_OK = "'',";
                var A2_RECINSS = "'',";
                var A2_TELEX = "'',";
                var A2_CODPAIS = "'',";
                var A2_CODLOC = "'',";
                var A2_TPESSOA = "'',";
                var A2_TPISSRS = "'',";
                var A2_MNOTA = "'0',";
                var A2_RECCIDE = "'',";
                var A2_GRPTRIB = "'',";
                var A2_UNFEDRP = "'',";
                var A2_CONTAB = "'',";
                var A2_CLIQF = "'',";
                var A2_PLGRUPO = "'',";
                var A2_CODBLO = "'',";
                var A2_PAISORI = "'',";
                var A2_ROYALTY = "'',";
                var A2_TXTRIBU = "'0',";
                var A2_B2B = "'',";
                var A2_PLCRRES = "'',";
                var A2_PLFIL = "'',";
                var A2_SIGLCR = "'',";
                var A2_CONREG = "'',";
                var A2_DATBLO = "'',";
                var A2_PLPEDES = "'0',";
                var A2_CNAE = "'',";
                var A2_CBO = "'',";
                var A2_CIVIL = "'',";
                var A2_ROYMIN = "'0',";
                var A2_SATIV1 = "'',";
                var A2_PAGAMEN = "'',";
                var A2_ENDCOMP = "'',";
                var A2_MSBLQL = "'',";
                var A2_GRPDEP = "'',";
                var A2_SUBCOD = "'',";
                var A2_TIPAWB = "'',";
                var A2_RECSEST = "'',";
                var A2_FILDEB = "'',";
                var A2_RECPIS = "'',";
                var A2_RECCOFI = "'',";
                var A2_RECCSLL = "'',";
                var A2_ABICS = "'',";
                var A2_CODFAV = "'',";
                var A2_LOJFAV = "'',";
                var A2_NUMDEP = "'0',";
                var A2_CALCIRF = "'',";
                var A2_VINCULO = "'',";
                var A2_DTINIV = "'',";
                var A2_DTFIMV = "'',";
                var A2_CODADM = "'',";
                var A2_RETISI = "'',";
                var A2_ISICM = "'',";
                var A2_CCICMS = "'',";
                var A2_INSCMU = "'',";
                var A2_SIMPNAC = "'',";
                var A2_CTARE = "'',";
                var A2_NUMRA = "'',";
                var A2_MJURIDI = "'',";
                var A2_CODINSS = "'',";
                var A2_IMPIP = "'',";
                var A2_RFACS = "'',";
                var A2_RFABOV = "'',";
                var A2_NEMPR = "'',";
                var A2_NIFEX = "'',";
                var A2_CPFIRP = "'',";
                var A2_REGESIM = "'',";
                var A2_PAISEX = "'',";
                var A2_RECFET = "'',";
                var A2_TPCON = "'',";
                var A2_PRSTSER = "'',";
                var A2_TPCONTA = "'',";
                var A2_TPRNTRC = "'',";
                var A2_STRNTRC = "'',";
                var A2_IDHIST = "'',";
                var A2_CPOMSP = "'',";
                var A2_EQPTAC = "'',";
                var A2_TPLOGR = "'',";
                var A2_INCULT = "'',";
                var A2_SITESBH = "'',";
                var A2_TPJ = "'',";
                var A2_FOMEZER = "'',";
                var A2_COMPLEM = "'',";
                var A2_FRETISS = "'',";
                var A2_ENDNOT = "'',";
                var A2_MUNSC = "'',";
                var A2_LOGEX = "'',";
                var A2_NUMEX = "'',";
                var A2_DTINIR = "'',";
                var A2_CGCEX = "'',";
                var A2_COMPLR = "'',";
                var A2_MINIRF = "'',";
                var A2_DTRNTRC = "'',";
                var A2_RNTRC = "'',";
                var A2_TPREX = "'',";
                var A2_TRBEX = "'',";
                var A2_BAIEX = "'',";
                var A2_BREEX = "'',";
                var A2_DTFIMR = "'',";
                var A2_INCLTMG = "'',";
                var A2_CONFFIS = "'',";
                var A2_CODSIAF = "'',";
                var A2_POSEX = "'',";
                var A2_CIDEX = "'',";
                var A2_ESTEX = "'',";
                var A2_TELRE = "'',";
                var A2_FILTRF = "'',";
                var A2_IRPROG = "'',";
                var A2_LOCQUIT = "'',";
                var A2_APOLICE = "'',";
                var A2_TRIBFAV = "'',";
                var A2_RESPTRI = "'',";
                var A2_RECFMD = "'',";
                var D_E_L_E_T_ = "'',";
                var R_E_C_N_O_ = "ISNULL((SELECT MAX(R_E_C_N_O_)+1 FROM " + nota.TabSA2 + "), 1),";
                var R_E_C_D_E_L_ = "'0',";
                var A2_INOVAUT = "'',";
                var A2_DTCONV = "'',";
                var A2_NOMRESP = "'',";
                var A2_CARGO = "'',";
                var A2_TIPCTA = "'',";
                var A2_MINPUB = "''";


                query += "INSERT INTO " + nota.TabSA2 + "(A2_FILIAL, A2_COD, A2_LOJA, A2_NOME, A2_NREDUZ, A2_END, A2_NR_END, A2_BAIRRO, A2_EST, A2_CONTPRE, A2_ESTADO, A2_COD_MUN, A2_MUN, A2_IBGE, A2_CEP, A2_CX_POST, A2_TIPO, A2_PFISICA, A2_CGC, A2_DDI, A2_DDD, A2_TEL, A2_FAX, A2_INSCR, A2_INSCRM, A2_CONTATO, A2_BANCO, A2_AGENCIA, A2_NUMCON, A2_SWIFT, A2_NATUREZ, A2_TRANSP, A2_PRIOR, A2_RISCO, A2_COND, A2_LC, A2_MATR, A2_MCOMPRA, A2_METR, A2_MSALDO, A2_NROCOM, A2_PRICOM, A2_ULTCOM, A2_SALDUP, A2_DESVIO, A2_SALDUPM, A2_CONTA, A2_TIPORUR, A2_RECISS, A2_PAIS, A2_DEPTO, A2_ID_FBFN, A2_STATUS, A2_GRUPO, A2_ATIVIDA, A2_ORIG_1, A2_ORIG_2, A2_ORIG_3, A2_VINCULA, A2_REPRES, A2_REPCONT, A2_REPRTEL, A2_REPRFAX, A2_REPR_EM, A2_REPR_EN, A2_REPBAIR, A2_REPRMUN, A2_REPREST, A2_REPRCEP, A2_REPPAIS, A2_ID_REPR, A2_REPR_BA, A2_REPR_AG, A2_REPR_CO, A2_REPRCGC, A2_RET_PAI, A2_COMI_SO, A2_EMAIL, A2_HPAGE, A2_CODMUN, A2_CONTCOM, A2_FATAVA, A2_FABRICA, A2_DTAVA, A2_DTVAL, A2_OK, A2_RECINSS, A2_TELEX, A2_CODPAIS, A2_CODLOC, A2_TPESSOA, A2_TPISSRS, A2_MNOTA, A2_RECCIDE, A2_GRPTRIB, A2_UNFEDRP, A2_CONTAB, A2_CLIQF, A2_PLGRUPO, A2_CODBLO, A2_PAISORI, A2_ROYALTY, A2_TXTRIBU, A2_B2B, A2_PLCRRES, A2_PLFIL, A2_SIGLCR, A2_CONREG, A2_DATBLO, A2_PLPEDES, A2_CNAE, A2_CBO, A2_CIVIL, A2_ROYMIN, A2_SATIV1, A2_PAGAMEN, A2_ENDCOMP, A2_MSBLQL, A2_GRPDEP, A2_SUBCOD, A2_TIPAWB, A2_RECSEST, A2_FILDEB, A2_RECPIS, A2_RECCOFI, A2_RECCSLL, A2_ABICS, A2_CODFAV, A2_LOJFAV, A2_NUMDEP, A2_CALCIRF, A2_VINCULO, A2_DTINIV, A2_DTFIMV, A2_CODADM, A2_RETISI, A2_ISICM, A2_CCICMS, A2_INSCMU, A2_SIMPNAC, A2_CTARE, A2_NUMRA, A2_MJURIDI, A2_CODINSS, A2_IMPIP, A2_RFACS, A2_RFABOV, A2_NEMPR, A2_NIFEX, A2_CPFIRP, A2_REGESIM, A2_PAISEX, A2_RECFET, A2_TPCON, A2_PRSTSER, A2_TPCONTA, A2_TPRNTRC, A2_STRNTRC, A2_IDHIST, A2_CPOMSP, A2_EQPTAC, A2_TPLOGR, A2_INCULT, A2_SITESBH, A2_TPJ, A2_FOMEZER, A2_COMPLEM, A2_FRETISS, A2_ENDNOT, A2_MUNSC, A2_LOGEX, A2_NUMEX, A2_DTINIR, A2_CGCEX, A2_COMPLR, A2_MINIRF, A2_DTRNTRC, A2_RNTRC, A2_TPREX, A2_TRBEX, A2_BAIEX, A2_BREEX, A2_DTFIMR, A2_INCLTMG, A2_CONFFIS, A2_CODSIAF, A2_POSEX, A2_CIDEX, A2_ESTEX, A2_TELRE, A2_FILTRF, A2_IRPROG, A2_LOCQUIT, A2_APOLICE, A2_TRIBFAV, A2_RESPTRI, A2_RECFMD, D_E_L_E_T_, R_E_C_N_O_, R_E_C_D_E_L_, A2_INOVAUT, A2_DTCONV, A2_NOMRESP, A2_CARGO, A2_TIPCTA, A2_MINPUB) ";
                query += "VALUES(";
                query += A2_FILIAL + A2_COD + A2_LOJA + A2_NOME + A2_NREDUZ + A2_END + A2_NR_END + A2_BAIRRO + A2_EST + A2_CONTPRE + A2_ESTADO + A2_COD_MUN + A2_MUN + A2_IBGE + A2_CEP + A2_CX_POST + A2_TIPO + A2_PFISICA + A2_CGC + A2_DDI + A2_DDD + A2_TEL + A2_FAX + A2_INSCR + A2_INSCRM + A2_CONTATO + A2_BANCO + A2_AGENCIA + A2_NUMCON + A2_SWIFT + A2_NATUREZ + A2_TRANSP + A2_PRIOR + A2_RISCO + A2_COND + A2_LC + A2_MATR + A2_MCOMPRA + A2_METR + A2_MSALDO + A2_NROCOM + A2_PRICOM + A2_ULTCOM + A2_SALDUP + A2_DESVIO + A2_SALDUPM + A2_CONTA + A2_TIPORUR + A2_RECISS + A2_PAIS + A2_DEPTO + A2_ID_FBFN + A2_STATUS + A2_GRUPO + A2_ATIVIDA + A2_ORIG_1 + A2_ORIG_2 + A2_ORIG_3 + A2_VINCULA + A2_REPRES + A2_REPCONT + A2_REPRTEL + A2_REPRFAX + A2_REPR_EM + A2_REPR_EN + A2_REPBAIR + A2_REPRMUN + A2_REPREST + A2_REPRCEP + A2_REPPAIS + A2_ID_REPR + A2_REPR_BA + A2_REPR_AG + A2_REPR_CO + A2_REPRCGC + A2_RET_PAI + A2_COMI_SO + A2_EMAIL + A2_HPAGE + A2_CODMUN + A2_CONTCOM + A2_FATAVA + A2_FABRICA + A2_DTAVA + A2_DTVAL + A2_OK + A2_RECINSS + A2_TELEX + A2_CODPAIS + A2_CODLOC + A2_TPESSOA + A2_TPISSRS + A2_MNOTA + A2_RECCIDE + A2_GRPTRIB + A2_UNFEDRP + A2_CONTAB + A2_CLIQF + A2_PLGRUPO + A2_CODBLO + A2_PAISORI + A2_ROYALTY + A2_TXTRIBU + A2_B2B + A2_PLCRRES + A2_PLFIL + A2_SIGLCR + A2_CONREG + A2_DATBLO + A2_PLPEDES + A2_CNAE + A2_CBO + A2_CIVIL + A2_ROYMIN + A2_SATIV1 + A2_PAGAMEN + A2_ENDCOMP + A2_MSBLQL + A2_GRPDEP + A2_SUBCOD + A2_TIPAWB + A2_RECSEST + A2_FILDEB + A2_RECPIS + A2_RECCOFI + A2_RECCSLL + A2_ABICS + A2_CODFAV + A2_LOJFAV + A2_NUMDEP + A2_CALCIRF + A2_VINCULO + A2_DTINIV + A2_DTFIMV + A2_CODADM + A2_RETISI + A2_ISICM + A2_CCICMS + A2_INSCMU + A2_SIMPNAC + A2_CTARE + A2_NUMRA + A2_MJURIDI + A2_CODINSS + A2_IMPIP + A2_RFACS + A2_RFABOV + A2_NEMPR + A2_NIFEX + A2_CPFIRP + A2_REGESIM + A2_PAISEX + A2_RECFET + A2_TPCON + A2_PRSTSER + A2_TPCONTA + A2_TPRNTRC + A2_STRNTRC + A2_IDHIST + A2_CPOMSP + A2_EQPTAC + A2_TPLOGR + A2_INCULT + A2_SITESBH + A2_TPJ + A2_FOMEZER + A2_COMPLEM + A2_FRETISS + A2_ENDNOT + A2_MUNSC + A2_LOGEX + A2_NUMEX + A2_DTINIR + A2_CGCEX + A2_COMPLR + A2_MINIRF + A2_DTRNTRC + A2_RNTRC + A2_TPREX + A2_TRBEX + A2_BAIEX + A2_BREEX + A2_DTFIMR + A2_INCLTMG + A2_CONFFIS + A2_CODSIAF + A2_POSEX + A2_CIDEX + A2_ESTEX + A2_TELRE + A2_FILTRF + A2_IRPROG + A2_LOCQUIT + A2_APOLICE + A2_TRIBFAV + A2_RESPTRI + A2_RECFMD + D_E_L_E_T_ + R_E_C_N_O_ + R_E_C_D_E_L_ + A2_INOVAUT + A2_DTCONV + A2_NOMRESP + A2_CARGO + A2_TIPCTA + A2_MINPUB;
                query += ");";
            }
            return query;
        }


        public static string sqlTES(string tipoErp, string codProd, string codFilial, string CodEmpErp, string tpNF = "", string codTabProd = "", string TabSF4 = "")
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
                return "SELECT SUBSTRING(F4.F4_CF, 2, 3) AS COMPCFOP, F4.F4_CODIGO FROM " + TabSF4 + " F4 INNER JOIN " + codTabProd + " B1 ON F4.F4_CODIGO = " + TipoEntSai + " WHERE " +
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
                    var R_E_C_N_O_ = "ISNULL((SELECT MAX(R_E_C_N_O_)+1 FROM SD1" + codTab + "0), 1)";
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
                    var R_E_C_N_O_  = "ISNULL((SELECT MAX(R_E_C_N_O_)+1 FROM SD2" + codTab + "0), 1),";
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
                return "SELECT TOP 1 B1_COD, B1_FILIAL, B1_TIPO, B1_UM FROM " + prodTab + " WHERE B1_POSIPI = '" + NCMProd + "' AND D_E_L_E_T_ <> '*'";
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
                    var R_E_C_N_O_  = "ISNULL((SELECT MAX(R_E_C_N_O_)+1 FROM SF1" + nota.CodEmpErp + "0), 1),";
                    var F1_CHVNFE   = "'" + nota.ChaveNfe + "'";

                    query = "INSERT INTO SF1" + nota.CodEmpErp + "0 (F1_FILIAL, F1_DOC, F1_SERIE, F1_FORNECE, F1_LOJA, F1_COND, F1_DUPL, F1_EMISSAO, F1_EST, F1_FRETE, F1_DESPESA, F1_BASEICM, F1_VALICM, F1_BASEIPI, F1_VALIPI, F1_VALMERC, F1_VALBRUT, F1_TIPO, F1_DESCONT, F1_DTDIGIT, F1_ORIGLAN, F1_CONTSOC, F1_IRRF, F1_ESPECIE, F1_II, F1_BASIMP5, F1_BASIMP6, F1_VALIMP5, F1_VALIMP6, F1_SEGURO, F1_MOEDA, F1_PREFIXO, F1_STATUS, F1_RECBMTO, F1_RECISS, R_E_C_N_O_, F1_CHVNFE) VALUES(";
                    query += F1_FILIAL + F1_DOC + F1_SERIE + F1_FORNECE + F1_LOJA + F1_COND + F1_DUPL + F1_EMISSAO + F1_EST + F1_FRETE + F1_DESPESA + F1_BASEICM + F1_VALICM + F1_BASEIPI + F1_VALIPI + F1_VALMERC + F1_VALBRUT + F1_TIPO + F1_DESCONT + F1_DTDIGIT + F1_ORIGLAN + F1_CONTSOC + F1_IRRF + F1_ESPECIE + F1_II + F1_BASIMP5 + F1_BASIMP6 + F1_VALIMP5 + F1_VALIMP6 + F1_SEGURO + F1_MOEDA + F1_PREFIXO + F1_STATUS + F1_RECBMTO + F1_RECISS + R_E_C_N_O_ + F1_CHVNFE;
                    query += ");";
                }
                //Notas de Saída
                else
                {
                    var F2_FILIAL       = "'" + nota.CodFilErp + "',";
                    var F2_DOC          = "'" + nota.NumNf + "',";
                    var F2_SERIE        = "'" + nota.serieNf + "',";
                    var F2_CLIENTE      = "'" + nota.CodCliForErp + "',";
                    var F2_CLIENT       = "'" + nota.CodCliForErp + "',";
                    var F2_LOJA         = "'" + nota.CodLojaCliForErp + "',";
                    var F2_LOJENT       = "'" + nota.CodLojaCliForErp + "',";
                    var F2_COND         = "'" + nota.CodCondPagto + "',";
                    var F2_DUPL         = "'" + nota.NumNf + "',";
                    var F2_EMISSAO      = "REPLACE(CAST(CAST('" + nota.DataEmissao + "' AS DATE) AS VARCHAR(20)), '-', ''),";
                    var F2_EST          = "'" + nota.UFDestinatario + "',";
                    var F2_FRETE        = "'" + nota.vFrete + "',";
                    var F2_DESPESA      = "'" + nota.vOutro + "',";
                    var F2_BASEICM      = "'" + nota.BaseIcms + "',";
                    var F2_VALICM       = "'" + nota.ValorIcms + "',";
                    var F2_BASEIPI      = "'" + (Convert.ToDouble(nota.vIPI) > 0 ? Convert.ToString(Convert.ToDouble(nota.ValorBruto) + Convert.ToDouble(nota.vOutro) + Convert.ToDouble(nota.vFrete) + Convert.ToDouble(nota.vSeg)) : "0") + "',";
                    var F2_VALIPI       = "'" + nota.vIPI + "',";
                    var F2_VALMERC      = "'" + nota.ValorBruto + "',";
                    var F2_VALBRUT      = "'" + nota.ValorBruto + "',";
                    var F2_TIPO         = "'N',";
                    var F2_DESCONT      = "'" + nota.vDesc + "',";
                    var F2_DTDIGIT      = "REPLACE(CAST(CAST(GETDATE() AS DATE) AS VARCHAR(20)), '-', ''),";
                    var F2_CONTSOC      = "'0',";
                    var F2_ESPECIE      = "'" + nota.EspNf + "',";
                    var F2_BASIMP5      = "'" + nota.vBCCofins + "',";
                    var F2_BASIMP6      = "'" + nota.BasePis + "',";
                    var F2_VALIMP5      = "'" + nota.vCOFINS + "',";
                    var F2_VALIMP6      = "'" + nota.ValorPis + "',";
                    var F2_SEGURO       = "'" + nota.vSeg + "',";
                    var F2_MOEDA        = "'1',";
                    var F2_PREFIXO      = "'1',";
                    var F2_RECISS       = "'2',";
                    var R_E_C_N_O_      = "ISNULL((SELECT MAX(R_E_C_N_O_)+1 FROM SF2" + nota.CodEmpErp + "0), 1),";
                    var F2_ICMFRET      = "'0',";
                    var F2_TIPOCLI      = "'" + nota.CodTipoCliFor + "',";
                    var F2_VOLUME1      = "'" + nota.qVol + "',";
                    var F2_VOLUME2      = "'0" + "',";
                    var F2_VOLUME3      = "'0" + "',";
                    var F2_VOLUME4      = "'0" + "',";
                    var F2_ICMSRET      = "'0" + "',";
                    var F2_PLIQUI       = "'" + nota.pesoL + "',";
                    var F2_PBRUTO       = "'" + nota.pesoB + "',";
                    var F2_HORA         = "SUBSTRING(CONVERT(VARCHAR(20), GETDATE(), 108), 1, 5),";
                    var F2_RECFAUT      = "'1',";
                    var F2_CHVNFE       = "'" + nota.ChaveNfe + "'";
                    query += "INSERT INTO SF2" + nota.CodEmpErp + "0(F2_FILIAL, F2_DOC, F2_SERIE, F2_CLIENTE, F2_CLIENT, F2_LOJA, F2_LOJENT, F2_COND, F2_DUPL, F2_EMISSAO, F2_EST, F2_FRETE, F2_DESPESA, ";
                    query += "F2_BASEICM,F2_VALICM,F2_BASEIPI,F2_VALIPI,F2_VALMERC,F2_VALBRUT,F2_TIPO,F2_DESCONT,F2_DTDIGIT,F2_CONTSOC,F2_ESPECIE,F2_BASIMP5,";
                    query += "F2_BASIMP6,F2_VALIMP5,F2_VALIMP6,F2_SEGURO,F2_MOEDA,F2_PREFIXO,F2_RECISS,R_E_C_N_O_,F2_ICMFRET,F2_TIPOCLI,F2_VOLUME1,F2_VOLUME2,F2_VOLUME3,F2_VOLUME4,";
                    query += "F2_ICMSRET,F2_PLIQUI, F2_PBRUTO,F2_HORA,F2_RECFAUT,F2_CHVNFE) ";
                    query += "VALUES (";
                    query += F2_FILIAL + F2_DOC + F2_SERIE + F2_CLIENTE + F2_CLIENT + F2_LOJA + F2_LOJENT + F2_COND + F2_DUPL + F2_EMISSAO + F2_EST + F2_FRETE + F2_DESPESA + F2_BASEICM + F2_VALICM + F2_BASEIPI + F2_VALIPI + F2_VALMERC + F2_VALBRUT + F2_TIPO + F2_DESCONT + F2_DTDIGIT + F2_CONTSOC + F2_ESPECIE + F2_BASIMP5 + F2_BASIMP6 + F2_VALIMP5 + F2_VALIMP6 + F2_SEGURO + F2_MOEDA + F2_PREFIXO + F2_RECISS + R_E_C_N_O_ + F2_ICMFRET + F2_TIPOCLI + F2_VOLUME1 + F2_VOLUME2 + F2_VOLUME3 + F2_VOLUME4 + F2_ICMSRET + F2_PLIQUI + F2_PBRUTO + F2_HORA + F2_RECFAUT + F2_CHVNFE;
                    query += ");";
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
        public static string sqlInserePedidoVenda(string tipoErp, XmlNfe nota, string C5_NUM)
        {
            //Esta função retorna um array, pois deve retornar o C5_NUM para ser utilizado nos itens
            string query = "";
            
            if (tipoErp.ToLower() == "protheus")
            {
                var C5_FILIAL   = "'" + nota.CodFilErp + "',";
                //var C5_NUM      = "ISNULL((SELECT REPLICATE('0', 6-LEN(MAX(C5_NUM)+1))+CAST(MAX(C5_NUM)+1 AS VARCHAR(6)) FROM SC5" + nota.CodEmpErp + "0 WHERE C5_FILIAL = '" + nota.CodFilErp + "'), '000001'),";
                //Valor atribuido para ser utilizado nos itens
                C5_NUM = "'" + C5_NUM + "',";
                var C5_TIPO     = "'N',";
                var C5_CLIENTE  = "'" + nota.CodCliForErp + "',";
                var C5_CLIENT   = "'" + nota.CodCliForErp + "',";
                var C5_LOJACLI  = "'" + nota.CodLojaCliForErp + "',";
                var C5_LOJAENT  = "'" + nota.CodLojaCliForErp + "',";
                var C5_TIPOCLI  = "'" + nota.TipoCli + "',";
                var C5_CONDPAG  = "'" + nota.CodCondPagto + "',";
                var C5_EMISSAO  = "REPLACE(CAST(CAST('" + nota.DataEmissao + "' AS DATE) AS VARCHAR(20)), '-', ''),";
                var C5_FRETE    = "'" + nota.vFrete + "',";
                var C5_SEGURO   = "'" + nota.vSeg + "',";
                var C5_DESPESA  = "'" + nota.vOutro + "',";
                var C5_MOEDA    = "'1',";
                var C5_PESOL    = "'" + nota.pesoL + "',";
                var C5_PBRUTO   = "'" + nota.pesoB + "',";
                var C5_LIBEROK  = "'S',";
                var C5_NOTA     = "'" + nota.NumNf + "',";
                var C5_SERIE    = "'" + nota.serieNf + "',";
                var C5_TIPLIB   = "'1',";
                var C5_DESCONT  = "'" + nota.vDesc + "',";
                var C5_TXMOEDA  = "'1',";
                var C5_TPCARGA  = "'2',";
                var C5_GERAWMS  = "'1',";
                var C5_SOLOPC   = "'1',";
                var R_E_C_N_O_ = "ISNULL((SELECT MAX(R_E_C_N_O_)+1 FROM SC5" + nota.CodEmpErp + "0), 1),";
                var R_E_C_D_E_L_ = "'0'";
                query += "INSERT INTO SC5" + nota.CodEmpErp + "0(C5_FILIAL, C5_NUM, C5_TIPO, C5_CLIENTE, C5_CLIENT, C5_LOJACLI, C5_LOJAENT, C5_TIPOCLI, C5_CONDPAG, C5_EMISSAO, C5_FRETE, C5_SEGURO, C5_DESPESA, C5_MOEDA,C5_PESOL,C5_PBRUTO,C5_LIBEROK,C5_NOTA,C5_SERIE,C5_TIPLIB,C5_DESCONT,C5_TXMOEDA,C5_TPCARGA,C5_GERAWMS,C5_SOLOPC,R_E_C_N_O_,R_E_C_D_E_L_) ";
                query += "VALUES (";
                query += C5_FILIAL + C5_NUM + C5_TIPO + C5_CLIENTE + C5_CLIENT + C5_LOJACLI + C5_LOJAENT + C5_TIPOCLI + C5_CONDPAG + C5_EMISSAO + C5_FRETE + C5_SEGURO + C5_DESPESA + C5_MOEDA + C5_PESOL + C5_PBRUTO + C5_LIBEROK + C5_NOTA + C5_SERIE + C5_TIPLIB + C5_DESCONT + C5_TXMOEDA + C5_TPCARGA + C5_GERAWMS + C5_SOLOPC + R_E_C_N_O_ + R_E_C_D_E_L_;
                query += ");";
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
                var C6_FILIAL   = "'" + nota.CodFilErp + "',";
                var C6_ITEM     = "'" + dadosProd.numItem + "',";
                var C6_PRODUTO  = "'" + dadosProd.codProdErp + "',";
                var C6_UM       = "'" + dadosProd.uCom + "',";
                var C6_QTDVEN   = "'" + dadosProd.qCom + "',";
                var C6_PRCVEN   = "'" + dadosProd.vUnCom + "',";
                var C6_VALOR    = "'" + dadosProd.vProd + "',";
                var C6_TES      = "'" + dadosProd.TES + "',";
                var C6_LOCAL    = "'01',";
                var C6_CF       = "'" + dadosProd.CFOP + "',";
                var C6_QTDENT   = "'" + dadosProd.qCom + "',";
                var C6_CLI      = "'" + nota.CodCliForErp + "',";
                var C6_ENTREG   = "REPLACE(CAST(CAST('" + nota.DataEmissao + "' AS DATE) AS VARCHAR(20)), '-', ''),";
                var C6_LOJA     = "'" + nota.CodLojaCliForErp + "',";
                var C6_NOTA     = "'" + nota.NumNf 
                    + "',";
                var C6_SERIE    = "'" + nota.serieNf + "',";
                var C6_DATFAT   = "REPLACE(CAST(CAST('" + nota.DataEmissao + "' AS DATE) AS VARCHAR(20)), '-', ''),";
                var C6_NUM      = "'" + C5Num + "',";
                var C6_DESCRI   = "'" + dadosProd.vDesc + "',";
                var C6_PRUNIT   = "'" + dadosProd.vUnCom + "',";
                //Implementar ICMS
                var C6_CLASFIS  = "'',";
                var C6_TPOP     = "'F',";
                var C6_SUGENTR  = "REPLACE(CAST(CAST('" + nota.DataEmissao + "' AS DATE) AS VARCHAR(20)), '-', ''),";
                var C6_RATEIO   = "'2',";
                var R_E_C_N_O_  = "ISNULL((SELECT MAX(R_E_C_N_O_) + 1 FROM SC6" + nota.CodEmpErp + "0), 1),";
                var R_E_C_D_E_L_ = "'0'";

                query += "INSERT INTO SC6" + nota.CodEmpErp + "0(C6_FILIAL,C6_ITEM,C6_PRODUTO,C6_UM,C6_QTDVEN,C6_PRCVEN,C6_VALOR,C6_TES,C6_LOCAL,C6_CF,C6_QTDENT,C6_CLI,C6_ENTREG,C6_LOJA,C6_NOTA,C6_SERIE,C6_DATFAT,C6_NUM,C6_DESCRI,C6_PRUNIT,C6_CLASFIS,C6_TPOP,C6_SUGENTR,C6_RATEIO,R_E_C_N_O_,R_E_C_D_E_L_) ";
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
                var C9_OK       = "'    ',";
                var C9_FILIAL   = "'" + nota.CodFilErp + "',";
                var C9_PEDIDO   = "'" + C5Num + "',";
                var C9_ITEM     = "'" + dadosProd.numItem + "',";
                var C9_CLIENTE  = "'" + nota.CodCliForErp + "',";
                var C9_LOJA     = "'" + nota.CodLojaCliForErp + "',";
                var C9_PRODUTO  = "'" + dadosProd.codProdErp + "',";
                var C9_QTDLIB   = "'" + dadosProd.qCom + "',";
                var C9_NFISCAL  = "'" + nota.NumNf + "',";
                var C9_SERIENF  = "'" + nota.serieNf + "',";
                var C9_DATALIB  = "REPLACE(CAST(CAST('" + nota.DataEmissao + "' AS DATE) AS VARCHAR(20)), '-', ''),";
                var C9_SEQUEN   = "'01',";
                var C9_PRCVEN   = "'" + dadosProd.vUnCom + "', ";
                var C9_BLEST    = "'10',";
                var C9_BLCRED   = "'10',";
                var C9_LOCAL    = "'01',";
                var C9_TPCARGA  = "'2',";
                var C9_NUMSEQ   = "ISNULL((SELECT REPLICATE('0', 6-LEN(MAX(C9_NUMSEQ)+1))+CAST(MAX(C9_NUMSEQ)+1 AS VARCHAR(6)) FROM SC9" + nota.CodEmpErp + "0), '000001'),";
                var C9_RETOPER  = "'2',";
                var R_E_C_N_O_  = "ISNULL((SELECT MAX(R_E_C_N_O_)+1 FROM SC9" + nota.CodEmpErp + "0), 1),";
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
            return "SELECT B1_GRTRIB FROM " + codTab + " WHERE B1_COD = '" + codProduto + "' AND B1_FILIAL = '" + codFilial + "' AND D_E_L_E_T_ <> '*'";
        }

        //Pauta
        public static string sqlPauta(string codTab, string UF, string codFilial, string GrpTrib)
        {
            return "SELECT F7_MARGEM, F7_VLR_ICM, F7_VLRICMP FROM SF7" + codTab + "0 WHERE F7_GRTRIB = '" + GrpTrib + "' AND F7_FILIAL = '" + codFilial + "' AND F7_EST = '" + UF + "' AND D_E_L_E_T_ <> '*'";
        }

        public static string sqlRegrasCst()
        {
            return "SELECT CONTEUDO, ORDEM FROM REGRASXML WHERE PROCESSO = 'CST' ORDER BY ORDEM";
        }

        /// <summary>
        /// Esta função retorna uma query para pegar a tabela que a empresa usa pela chave
        /// </summary>
        /// <param name="codEmp"></param>
        /// <param name="chaveTab"></param>
        /// <returns></returns>
        public static string pegaTabelaSx2(string codEmp, string chaveTab)
        {
            return "SELECT TOP 1 X2_ARQUIVO FROM SX2" + codEmp + "0 WHERE X2_CHAVE = '" + chaveTab + "';";
        }


        public static string insereFinanceiro(XmlNfe nota, string dVenc, string vDup, string parcela)
        {
            var query = "";
            //Notas de Entrada
            if (nota.TipoNf == "SAIDA")
            {
                query += "insert into SE1" + nota.CodEmpErp + "0(E1_FILIAL, E1_PREFIXO, E1_NUM, E1_PARCELA, E1_TIPO, E1_NATUREZ, E1_PORTADO, E1_AGEDEP, E1_CLIENTE, E1_LOJA, E1_NOMCLI, E1_EMISSAO, E1_VENCTO, E1_VENCREA, E1_VALOR, E1_BASEIRF, E1_IRRF, E1_ISS, E1_NUMBCO, E1_INDICE, E1_BAIXA, E1_NUMBOR, E1_DATABOR, E1_EMIS1, E1_HIST, E1_LA, E1_LOTE, E1_MOTIVO, E1_MOVIMEN, E1_OP, E1_SITUACA, E1_CONTRAT, E1_SALDO, E1_SUPERVI, E1_VEND1, E1_VEND2, E1_VEND3, E1_VEND4, E1_VEND5, E1_COMIS1, E1_COMIS2, E1_COMIS3, E1_COMIS4, E1_DESCONT, E1_COMIS5, E1_MULTA, E1_JUROS, E1_CORREC, E1_VALLIQ, E1_VENCORI, E1_CONTA, E1_VALJUR, E1_PORCJUR, E1_MOEDA, E1_BASCOM1, E1_BASCOM2, E1_BASCOM3, E1_BASCOM4, E1_BASCOM5, E1_FATPREF, E1_FATURA, E1_OK, E1_PROJETO, E1_CLASCON, E1_VALCOM1, E1_VALCOM2, E1_VALCOM3, E1_VALCOM4, E1_VALCOM5, E1_OCORREN, E1_INSTR1, E1_INSTR2, E1_PEDIDO, E1_DTVARIA, E1_VARURV, E1_VLCRUZ, E1_DTFATUR, E1_NUMNOTA, E1_SERIE, E1_STATUS, E1_ORIGEM, E1_IDENTEE, E1_NUMCART, E1_FLUXO, E1_DESCFIN, E1_DIADESC, E1_TIPODES, E1_CARTAO, E1_CARTVAL, E1_CARTAUT, E1_ADM, E1_VLRREAL, E1_TRANSF, E1_BCOCHQ, E1_AGECHQ, E1_CTACHQ, E1_NUMLIQ, E1_ORDPAGO, E1_RECIBO, E1_INSS, E1_FILORIG, E1_DTACRED, E1_TIPOFAT, E1_TIPOLIQ, E1_CSLL, E1_COFINS, E1_PIS, E1_FLAGFAT, E1_MESBASE, E1_ANOBASE, E1_PLNUCOB, E1_CODINT, E1_CODEMP, E1_MATRIC, E1_TXMOEDA, E1_ACRESC, E1_SDACRES, E1_DECRESC, E1_SDDECRE, E1_MULTNAT, E1_MSFIL, E1_MSEMP, E1_PROJPMS, E1_DESDOBR, E1_NRDOC, E1_MODSPB, E1_EMITCHQ, E1_IDCNAB, E1_PLCOEMP, E1_PLTPCOE, E1_CODCOR, E1_PARCCSS, E1_CODORCA, E1_CODIMOV, E1_FILDEB, E1_NUMSOL, E1_NUMRA, E1_INSCRIC, E1_SERREC, E1_DATAEDI, E1_CODBAR, E1_CODDIG, E1_CHQDEV, E1_LIDESCF, E1_VLBOLSA, E1_VLFIES, E1_NUMCRD, E1_DEBITO, E1_CCD, E1_ITEMD, E1_CLVLDB, E1_CREDIT, E1_CCC, E1_ITEMC, E1_CLVLCR, E1_DESCON1, E1_DESCON2, E1_DTDESC3, E1_DTDESC1, E1_DTDESC2, E1_VLMULTA, E1_DESCON3, E1_MOTNEG, E1_SABTPIS, E1_SABTCOF, E1_SABTCSL, E1_FORNISS, E1_PARTOT, E1_SITFAT, E1_BASEPIS, E1_BASECOF, E1_BASECSL, E1_VRETISS, E1_PARCIRF, E1_SCORGP, E1_FRETISS, E1_TXMDCOR, E1_SATBIRF, E1_TIPREG, E1_CONEMP, E1_VERCON, E1_SUBCON, E1_VERSUB, E1_PLLOTE, E1_PLOPELT, E1_CODRDA, E1_FORMREC, E1_BCOCLI, E1_AGECLI, E1_CTACLI, E1_PARCFET, E1_FETHAB, E1_MDCRON, E1_MDCONTR, E1_MEDNUME, E1_MDPLANI, E1_MDPARCE, E1_MDREVIS, E1_NUMMOV, E1_PREFORI, E1_IDMOV, E1_NUMPRO, E1_INDPRO, E1_MDMULT, E1_MDBONI, E1_MDDESC, E1_RETCNTR, E1_NODIA, E1_MULTDIA, E1_JURFAT, E1_RELATO, E1_BASEINS, E1_TITPAI, E1_NFELETR, E1_DOCTEF, E1_PRINSS, E1_PARCFAB, E1_PARCFAC, E1_PARTPDP, E1_TPDESC, E1_TPDP, E1_VLMINIS, E1_FACS, E1_FABOV, E1_NUMCON, E1_SABTIRF, E1_IDLAN, E1_IDBOLET, E1_SERVICO, E1_VLBOLP, E1_IDAPLIC, E1_PROCEL, E1_NUMINSC, E1_DIACTB, E1_LTCXA, E1_NOPER, E1_TURMA, E1_NSUTEF, E1_VRETIRF, E1_APLVLMN, E1_BASEISS, E1_SEQBX, E1_RATFIN, E1_CODIRRF, E1_PRISS, E1_CODISS, D_E_L_E_T_, R_E_C_N_O_, R_E_C_D_E_L_, E1_FAMAD, E1_PARCFAM, E1_FMPEQ, E1_PARCFMP, E1_CTRBCO, E1_PRODUTO, E1_PERLET, E1_CHAVENF) ";
                query += "SELECT ";
                query += "F2_FILIAL AS E1_FILIAL, ";
                query += "'" + nota.serieNf +"' AS E1_PREFIXO, ";
                query += "F2_DOC AS E1_NUM, ";
                query += "'" + parcela + "' AS E1_PARCELA, ";
                query += "'NF' AS E1_TIPO, ";
                query += "'' AS E1_NATUREZ, ";
                query += "'' AS E1_PORTADO, ";
                query += "'' AS E1_AGEDP, ";
                query += "F2_CLIENTE AS E1_CLIENTE, ";
                query += "F2_LOJA AS E1_LOJA, ";
                query += "ISNULL((SELECT TOP 1 A1_NREDUZ FROM " + nota.TabSA1 + " WHERE A1_COD = F2_CLIENTE AND A1_FILIAL = F2_FILIAL), '') AS E1_NOMCLI, ";
                query += "F2_EMISSAO AS E1_EMISSAO, ";
                query += "SUBSTRING(REPLACE('" + dVenc + "', '-', ''), 1, 8) AS E1_VENCTO, ";
                query += "SUBSTRING(REPLACE('" + dVenc + "', '-', ''), 1, 8) E1_VENCREA, ";
                query += "'" + vDup + "' AS E1_VALOR, ";
                query += "F2_BASEIRR AS E1_BASEIRF, ";
                query += "F2_VALIRRF AS E1_IRRF, ";
                query += "F2_VALISS AS E1_ISS, ";
                query += "'' AS E1_NUMBCO, ";
                query += "'' AS E1_INDICE, ";
                query += "'' AS E1_BAIXA, ";
                query += "'' AS E1_NUMBOR, ";
                query += "'' AS E1_DATABOR, ";
                query += "F2_EMISSAO AS E1_EMIS1, ";
                query += "'' AS E1_HIST, ";
                query += "'S' AS E1_LA, ";
                query += "F2_LOTE AS E1_LOTE, ";
                query += "'' AS E1_MOTIVO, ";
                query += "'' AS E1_MOVIMEN, ";
                query += "'' AS E1_OP, ";
                query += "'0' AS E1_SITUACA, ";
                query += "'' AS E1_CONTRAT, ";
                query += "'" + vDup + "' AS E1_SALDO, ";
                query += "'' AS E1_SUPERVI, ";
                query += "F2_VEND1 AS E1_VEND1, ";
                query += "F2_VEND2 AS E2_VEND2, ";
                query += "F2_VEND3 AS E2_VEND3, ";
                query += "F2_VEND4 AS E2_VEND4, ";
                query += "F2_VEND5 AS E2_VEND5, ";
                query += "'0' AS E1_COMIS1, ";
                query += "'0' AS E1_COMIS2, ";
                query += "'0' AS E1_COMIS3, ";
                query += "'0' AS E1_COMIS4, ";
                query += "F2_DESCONT AS E1_DESCONT, ";
                query += "'0' AS E1_COMIS5, ";
                query += "'0' AS E1_MULTA, ";
                query += "'0' AS E1_JUROS, ";
                query += "'0' AS E1_CORREC, ";
                query += "'0' AS E1_VALLIQ, ";
                query += "F2_EMISSAO AS E1_VENCORI, ";
                query += "'' AS E1_CONTA, ";
                query += "'0' AS E1_VALJUR, ";
                query += "'' AS E1_PORCJUR, ";
                query += "F2_MOEDA AS E1_MOEDA, ";
                query += "'0' AS E1_BASCOM1, ";
                query += "'0' AS E1_BASCOM2, ";
                query += "'0' AS E1_BASCOM3, ";
                query += "'0' AS E1_BASCOM4, ";
                query += "'0' AS E1_BASCOM5, ";
                query += "'' AS FATPREF, ";
                query += "'' AS E1_FATURA, ";
                query += "'' AS E1_OK, ";
                query += "'' AS E1_PROJETO, ";
                query += "'' AS E1_CLASCON, ";
                query += "'0' AS E1_VALCOM1, ";
                query += "'0' AS E1_VALCOM2, ";
                query += "'0' AS E1_VALCOM3, ";
                query += "'0' AS E1_VALCOM4, ";
                query += "'0' AS E1_VALCOM5, ";
                query += "'01' AS E1_OCORREN, ";
                query += "'' AS E1_INSTR1, ";
                query += "'' AS E1_INSTR2, ";
                query += "'' AS E1_PEDIDO, ";
                query += "'' AS E1_DTVARIA, ";
                query += "'0' AS E1_VARURV, ";
                query += "F2_VALFAT AS E1_VLCRUZ, ";
                query += "'' AS E1_DTFATUR, ";
                query += "'' AS E1_NUMNOTA, ";
                query += "'' AS E1_SERIE, ";
                query += "'' AS E1_STATUS, ";
                query += "'MATA460' AS E1_ORIGEM, ";
                query += "'' AS E1_IDENTEE, ";
                query += "'' AS E1_NUMCART, ";
                query += "'' AS E1_FLUXO, ";
                query += "'0' AS E1_DESCFIN, ";
                query += "'0' AS E1_DIADESC, ";
                query += "'' AS E1_TIPODES, ";
                query += "'' AS E1_CARTAO, ";
                query += "'' AS E1_CARTVAL, ";
                query += "'' AS E1_CARTAUT, ";
                query += "'' AS E1_ADM, ";
                query += "'0' AS E1_VLRREAL, ";
                query += "'' AS E1_TRANSF, ";
                query += "'' AS E1_BCOHQ, ";
                query += "'' AS E1_AGEHG, ";
                query += "'' AS E1_CTAHQ, ";
                query += "'' AS E1_NUMLIQ, ";
                query += "'' AS E1_ORDPAGO, ";
                query += "'' AS E1_RECIBO, ";
                query += "F2_VALINSS AS E1_INSS, ";
                query += "F2_FILIAL AS E1_FILORIG, ";
                query += "'' AS E1_DTACRED, ";
                query += "'' AS E1_TIPOFAT, ";
                query += "'' AS E1_TIPOLIQ, ";
                query += "F2_VALCSLL AS E1_CSLL, ";
                query += "F2_VALCOFI AS E1_COFINS, ";
                query += "F2_VALPIS AS E1_PIS, ";
                query += "'' AS E1_FLAGFAT, ";
                query += "'' AS E1_MESBASE, ";
                query += "'' AS E1_ANOBASE, ";
                query += "'' AS E1_PLNUCOB, ";
                query += "'' AS E1_CODINT, ";
                query += "'' AS E1_CODEMP, ";
                query += "'' AS E1_MATRIC, ";
                query += "F2_TXMOEDA AS E1_TXMOEDA, ";
                query += "F2_VALACRS AS E1_ACRESC, ";
                query += "'' AS E1_SDACRES, ";
                query += "'0' AS E1_DECRESC, ";
                query += "'0' AS E1_SDDECRE, ";
                query += "'' AS E1_MULTNAT, ";
                query += "F2_FILIAL AS E1_MSFIL, ";
                query += "'" + nota.CodEmpErp + "' AS E1_MSEMP, "; 
                query += "'' AS E1_PROJPMS, ";
                query += "'' AS E1_DESDOBR, ";
                query += "'' AS E1_NRDOC, ";
                query += "'' AS E1_MODSPB, ";
                query += "'' AS E1_EMITCHQ, ";
                query += "'' AS E1_IDCNAB, ";
                query += "'' AS E1_PLCOEMP, ";
                query += "'' AS E1_PLTPCOE, ";
                query += "'' AS E1_CODCOR, ";
                query += "'' AS E1_PARCCSS, ";
                query += "'' AS E1_CODORCA, ";
                query += "'' AS E1_CODIMOV, ";
                query += "'' AS E1_FILDEB, ";
                query += "'' AS E1_NUMSOL, ";
                query += "'' AS E1_NUMRA, ";
                query += "'' AS E1_INSCRIC, ";
                query += "'' AS E1_SERREC, ";
                query += "'' AS E1_DATAEDI, ";
                query += "'' AS E1_CODBAR, ";
                query += "'' AS E1_CODDIG, ";
                query += "'' AS E1_CHQDEV, ";
                query += "'' AS E1_LIDESCF, ";
                query += "'0' AS VLBOLSA, ";
                query += "'0' AS E1_VLFIES, ";
                query += "'' AS E1_NUMCRD, ";
                query += "'' AS E1_DEBITO, ";
                query += "'' AS E1_CCD, ";
                query += "'' AS E1_ITEMD, ";
                query += "'' AS E1_CLVDB, ";
                query += "'' AS E1_CREDIT, ";
                query += "'1' AS E1_CCC, ";
                query += "'' AS E1_ITEMC, ";
                query += "'' AS E1_CLVLCR, ";
                query += "'0' AS E1_DESCON1, ";
                query += "'0' AS E1_DESCON2, ";
                query += "'' AS E1_DTDESC3, ";
                query += "'' AS E1_DTDESC1, ";
                query += "'' AS E1_DTDESC2, ";
                query += "'0' AS E1_VLMULTA, ";
                query += "'0' AS E1_DESCON3, ";
                query += "'' AS E1_MOTNEG, ";
                query += "'0' AS E1_SABTPIS, ";
                query += "'0' AS E1_SABTCOF, ";
                query += "'0' AS E1_SABTCSL, ";
                query += "'' AS E1_FORNISS, ";
                query += "'' AS E1_PARTOT, ";
                query += "'' AS E1_SITFAT, ";
                query += "F2_BASPIS AS E1_BASEPIS, ";
                query += "F2_BASCOFI AS E1_BASECOF, ";
                query += "F2_BASCSLL AS E1_BASECSL, ";
                query += "'0' AS E1_VRETISS, ";
                query += "'' AS E1_PARCIRF, ";
                query += "'' AS E1_SCORGP, ";
                query += "'1' AS E1_FRETISS, ";
                query += "'0' AS E1_TXMDCOR, ";
                query += "'0' AS E1_SATBIRF, ";
                query += "'' AS E1_TIPREG, ";
                query += "'' AS E1_CONEMP, ";
                query += "'' AS E1_VERCON, ";
                query += "'' AS E1_SUBCON, ";
                query += "'' AS E1_VERSUB, ";
                query += "'' AS E1_PLLOTE, ";
                query += "'' AS E1_PLOPELT, ";
                query += "'' AS E1_CODRDA, ";
                query += "'' AS E1_FORMREC, ";
                query += "'' AS E1_BCOCLI, ";
                query += "'' AS E1_AGECLI, ";
                query += "'' AS E1_CTACLI, ";
                query += "'' AS E1_PARCFET, ";
                query += "'0' AS E1_FETHAB, ";
                query += "'' AS E1_MDCRON, ";
                query += "'' AS E1_MDCONTR, ";
                query += "'' AS E1_MEDNUME, ";
                query += "'' AS E1_MDPLANI, ";
                query += "'' AS E1_MDPARCE, ";
                query += "'' AS E1_MDREVIS, ";
                query += "'' AS E1_NUMMOV, ";
                query += "'' AS E1_PREFORI, ";
                query += "'' AS E1_IDMOV, ";
                query += "'' AS E1_NUMPRO, ";
                query += "'' AS E1_INDPRO, ";
                query += "'0' AS E1_MDMULT, ";
                query += "'0' AS E1_MDBONI, ";
                query += "'0' AS E1_MDDESC, ";
                query += "'0' AS E1_RETCNTR, ";
                query += "'' AS E1_NODIA, ";
                query += "'0' AS E1_MULTDIA, ";
                query += "'' AS E1_JURFAT, ";
                query += "'2' AS E1_RELATO, ";
                query += "'0' AS E1_BASEINS, ";
                query += "'' AS E1_TITPAI, ";
                query += "'' AS E1_NFELETR, ";
                query += "'' AS E1_DOCTEF, ";
                query += "'0' AS E1_PRINSS, ";
                query += "'' AS E1_PARCFAB, ";
                query += "'' AS E1_PARCFAC, ";
                query += "'' AS E1_PARTPDP, ";
                query += "'C' AS E1_TPDESC, ";
                query += "'0' AS E1_TPDP, ";
                query += "'' AS E1_VLMINIS, ";
                query += "'0' AS E1_FACS, ";
                query += "'0' AS E1_FABOV, ";
                query += "'' AS E1_NUMCON, ";
                query += "'0' AS E1_SABTIRF, ";
                query += "'0' E1_IDLAN, ";
                query += "'0' AS E1_IDBOLET, ";
                query += "'0' AS E1_SERVICO, ";
                query += "'0' AS E1_VLBOLP, ";
                query += "'0' AS E1_IDAPLIC, ";
                query += "'0' AS E1_PROCEL, ";
                query += "'0' AS E1_NUMINSC, ";
                query += "'' AS E1_DIACTB, ";
                query += "'' AS E1_LTCXA, ";
                query += "'0' AS E1_NOPER, ";
                query += "'' AS E1_TURMA, ";
                query += "'' AS E1_NSUTEF, ";
                query += "F2_VALIRRF AS E1_VRETIRF, ";
                query += "'1' AS E1_APLVLMN, ";
                query += "'0' AS E1_BASEISS, ";
                query += "'' AS E1_SEQBX, ";
                query += "'' AS E1_RATFIN, ";
                query += "'' AS E1_CODIRRF, ";
                query += "'0' AS E1_PRISS, ";
                query += "'' AS E1_CODISS, ";
                query += "'' AS D_E_L_E_T_, ";
                query += "ISNULL((SELECT MAX(R_E_C_N_O_)+1 FROM SE1" + nota.CodEmpErp + "0), 1) R_E_C_N_O_, ";
                query += "'0' AS R_E_C_D_E_L_, ";
                query += "'0' AS E1_FAMAD, ";
                query += "'' AS E1_PARCFAM, ";
                query += "'0' AS E1_FMPEQ, ";
                query += "'' AS E1_PARCFMP, ";
                query += "'' AS E1_CTRBCO, ";   
                query += "'' AS E1_PRODUTO, ";
                query += "'' AS E1_PERLET, ";
                query += "'' AS E1_CHAVENF ";
                query += "FROM " + nota.TabSF2 + " WHERE F2_CHVNFE = '" + nota.ChaveNfe + "';";

            }
            //Notas de Saída
            else
            {
                query = "insert into SE2" + nota.CodEmpErp + @"0(E2_FILIAL, E2_PREFIXO, E2_NUM, E2_PARCELA, E2_TIPO, E2_NATUREZ, E2_PORTADO, E2_FORNECE, E2_LOJA, E2_NOMFOR, E2_EMISSAO, E2_VENCTO, E2_VENCREA, E2_VALOR, E2_ISS, E2_IRRF, E2_NUMBCO, E2_INDICE, E2_BAIXA, E2_BCOPAG, E2_EMIS1, E2_HIST, E2_LA, E2_LOTE, E2_MOTIVO, E2_MOVIMEN, E2_OP, E2_SALDO, E2_OK, E2_DESCONT, E2_MULTA, E2_JUROS, E2_CORREC, E2_VALLIQ, E2_VENCORI, E2_VALJUR, E2_PORCJUR, E2_MOEDA, E2_NUMBOR, E2_FATPREF, E2_FATURA, E2_PROJETO, E2_CLASCON, E2_RATEIO, E2_DTVARIA, E2_VARURV, E2_VLCRUZ, E2_DTFATUR, E2_ACRESC, E2_TITORIG, E2_IMPCHEQ, E2_PARCIR, E2_ARQRAT, E2_OCORREN, E2_ORIGEM, E2_IDENTEE, E2_FLUXO, E2_PARCISS, E2_ORDPAGO, E2_DESDOBR, E2_INSS, E2_PARCINS, E2_NUMLIQ, E2_BCOCHQ, E2_AGECHQ, E2_CTACHQ, E2_DATALIB, E2_APROVA, E2_TIPOFAT, E2_FLAGFAT, E2_ANOBASE, E2_MESBASE, E2_TXMOEDA, E2_SDACRES, E2_DECRESC, E2_SDDECRE, E2_USUALIB, E2_MULTNAT, E2_NUMTIT, E2_PROJPMS, E2_PLLOTE, E2_DIRF, E2_CODRET, E2_MODSPB, E2_IDCNAB, E2_PARCCSS, E2_RETENC, E2_CONTAD, E2_CODORCA, E2_SEST, E2_PARCSES, E2_FILDEB, E2_FILORIG, E2_FORNISS, E2_LOJAISS, E2_DEBITO, E2_CCD, E2_ITEMD, E2_CLVLDB, E2_CREDIT, E2_CCC, E2_ITEMC, E2_CLVLCR, E2_COFINS, E2_PIS, E2_CSLL, E2_PARCCOF, E2_PARCPIS, E2_PARCSLL, E2_TITPIS, E2_TITCOF, E2_TITCSL, E2_TITINS, E2_VRETPIS, E2_VRETCOF, E2_VRETCSL, E2_PRETPIS, E2_PRETCOF, E2_PRETCSL, E2_SEQBX, E2_CODBAR, E2_BASECOF, E2_BASEPIS, E2_BASECSL, E2_VRETISS, E2_VENCISS, E2_VBASISS, E2_MDRTISS, E2_VARIAC, E2_PERIOD, E2_MDCONTR, E2_MDREVIS, E2_MDPLANI, E2_MDCRON, E2_MDPARCE, E2_FRETISS, E2_TXMDCOR, E2_APLVLMN, E2_CLEARIN, E2_HORASPB, E2_PRETIRF, E2_SEFIP, E2_TRETISS, E2_VRETIRF, E2_PLOPELT, E2_CODRDA, E2_PARCFET, E2_FETHAB, E2_FORORI, E2_LOJORI, E2_STATUS, E2_DTDIRF, E2_TITADT, E2_TITPAI, E2_INSSRET, E2_CODAGL, E2_PROCPCC, E2_FORNPAI, E2_CODISS, E2_USUASUS, E2_USUACAN, E2_DATASUS, E2_DATACAN, E2_LIMCAN, E2_PREOP, E2_BASEISS, E2_NUMPRO, E2_INDPRO, E2_PARCAGL, E2_NODIA, E2_DIACTB, E2_MDMULT, E2_MDBONI, E2_MDDESC, E2_RETCNTR, E2_CIDE, E2_PRETINS, E2_VRETINS, E2_FATFOR, E2_FATLOJ, E2_BASEIRF, E2_DATAAGE, E2_TEMDOCS, E2_STATLIB, E2_CODAPRO, E2_IDMOV, E2_PRINSS, E2_BASEINS, E2_PARCCID, E2_CODRCSL, E2_CODRPIS, E2_CODRCOF, E2_TIPOLIQ, E2_PARIMP5, E2_PARIMP4, E2_PARIMP3, E2_PARIMP2, E2_PARIMP1, E2_CODINS, E2_IDDARF, E2_DTBORDE, E2_MSIDENT, E2_PRISS, E2_RATFIN, E2_NUMSOL, E2_CODOPE, E2_FABOV, E2_FACS, E2_PARCFAB, E2_PARCFAC, E2_FIMP, E2_NFELETR, E2_AGLIMP, D_E_L_E_T_, R_E_C_N_O_, R_E_C_D_E_L_, E2_FAMAD, E2_PARCFAM, E2_FMPEQ, E2_PARCFMP, E2_FORBCO, E2_FORAGE, E2_FAGEDV, E2_FORCTA, E2_FCTADV) ";
                query += "select TOP 1 ";
                query += "F1_FILIAL AS E2_FILIAL, ";
                query += "'"+ nota.serieNf +"' AS E2_PREFIXO, ";
                query += "F1_DOC AS E2_NUM, ";
                query += "'"+ parcela + "' AS E2_PARCELA, ";
                query += "'NF' AS E2_TIPO, ";
                query += "'1000' AS E2_NATUREZ, ";
                query += "'' AS E2_PORTADO, ";
                query += "F1_FORNECE AS E2_FORNECE, ";
                query += "F1_LOJA AS E2_LOJA, ";
                query += "ISNULL((SELECT TOP 1 A2_NREDUZ FROM " + nota.TabSA2 + " WHERE A2_COD = F1_FORNECE AND A2_FILIAL = F1_FILIAL), '') AS E2_NOMFOR, ";
                query += "F1_EMISSAO AS E2_EMISSAO, ";
                query += "REPLACE('" + dVenc + "', '-', '') AS E2_VENCTO, ";
                query += "REPLACE('" + dVenc + "', '-', '') AS E2_VENCREA, ";
                query += "'" + vDup + "' AS E2_VALOR, ";
                query += "F1_ISS AS E2_ISS, ";
                query += "F1_IRRF AS E2_IRRF, ";
                query += "'' AS E2_NUMBCO, ";
                query += "'' AS E2_INDICE, ";
                query += "'' AS E2_BAIXA, ";
                query += "'' AS E2_BCOPAG, ";
                query += "'' AS E2_EMIS1, ";
                query += "'' AS E2_HIST, ";
                query += "'' AS E2_LA, ";
                query += "'' AS E2_LOTE, ";
                query += "'' AS E2_MOTIVO, ";
                query += "'' AS E2_MOVIMEN, ";
                query += "'' AS E2_OP, ";
                query += "'" + vDup + "' AS E2_SALDO, ";
                query += "'' AS E2_OK, ";
                query += "F1_DESCONT AS E2_DESCONT, ";
                query += "'0' AS E2_MULTA, ";
                query += "'0' AS E2_JUROS, ";
                query += "'0' AS E2_CORREC, ";
                query += "'0' AS E2_VALLIQ, ";
                query += "F1_EMISSAO AS E2_VENCORI, ";
                query += "'0' AS E2_VALJUR, ";
                query += "'0' AS E2_PORCJUR, ";
                query += "F1_MOEDA AS E2_MOEDA, ";
                query += "'' AS E2_NUMBOR, ";
                query += "'' AS E2_FATPREF, ";
                query += "'' AS E2_FATURA, ";
                query += "'' AS E2_PROJETO, ";
                query += "'' AS E2_CLASCON, ";
                query += "'N' AS E2_RATEIO, ";
                query += "'' AS E2_DTVARIA, ";
                query += "'0' AS E2_VARURV, ";
                query += "'" + vDup +"' AS E2_VLCRUZ, ";
                query += "'' AS E2_DTFATUR, ";
                query += "'0' AS E2_ACRESC, ";
                query += "'' AS E2_TITORIG, ";
                query += "'' AS E2_IMPCHEQ, ";
                query += "'' AS E2_PARCIR, ";
                query += "'' AS E2_ARQRAT, ";
                query += "'01' AS E2_OCORREN, ";
                query += "'INSPETOR' AS E2_ORIGEM, ";
                query += "'' AS E2_IDENTEE, ";
                query += "'S' AS E2_FLUXO, ";
                query += "'' AS E2_PARCISS, ";
                query += "'' AS E2_ORDPAGO, ";
                query += "'N' AS E2_DESDOBR, ";
                query += "F1_INSS AS E2_INSS, ";
                query += "'' AS E2_PARCINS, ";
                query += "'' AS E2_NUMLIQ, ";
                query += "'' AS E2_BCOCHQ, ";
                query += "'' AS E2_AGECHQ, ";
                query += "'' AS E2_CTACHQ, ";
                query += "'' AS E2_DATALIB, ";
                query += "'' AS E2_APROVA, ";
                query += "'' AS E2_TIPOFAT, ";
                query += "'' AS E2_FLAGFAT, ";
                query += "'' AS E2_ANOBASE, ";
                query += "'' AS E2_MESBASE, ";
                query += "F1_TXMOEDA AS E2_TXMOEDA, ";
                query += "'0' AS E2_SDACRES, ";
                query += "'0' AS E2_DECRESC, ";
                query += "'0' AS E2_SDDECRE, ";
                query += "'' AS E2_USUALIB, ";
                query += "'2' AS E2_MULTNAT, ";
                query += "'' AS E2_NUMTIT, ";
                query += "'2' AS E2_PROJPMS, ";
                query += "'' AS E2_PLLOTE, ";
                query += "'1' AS E2_DIRF, ";
                query += "'' AS E2_CODRET, ";
                query += "'1' AS E2_MODSPB, ";
                query += "'' AS E2_IDCNAB, ";
                query += "'' AS E2_PARCCSS, ";
                query += "'0' AS E2_RETENC, ";
                query += "'' AS E2_CONTAD, ";
                query += "'' AS E2_CODORCA, ";
                query += "'0' AS E2_SEST, ";
                query += "'' AS E2_PARCSES, ";
                query += "'' E2_FILDEB, ";
                query += "F1_FILORIG AS E2_FILORIG, ";
                query += "'' AS E2_FORNISS, ";
                query += "'' AS E2_LOJAISS, ";
                query += "'' AS E2_DEBITO, ";
                query += "'' as E2_CCD, ";
                query += "'' AS E2_ITEMD, ";
                query += "'' AS E2_CLVLDB, ";
                query += "'' AS E2_CREDIT, ";
                query += "'' AS E2_CCC, ";
                query += "'' AS E2_ITEMC, ";
                query += "'' AS E2_CLVLCR, ";
                query += "F1_VALCOFI AS E2_COFINS, ";
                query += "F1_VALPIS AS E2_PIS, ";
                query += "F1_VALCSLL AS E2_CSLL, ";
                query += "'' AS E2_PARCCOF, ";
                query += "'' AS E2_PARCPIS, ";
                query += "'' AS E2_PARCSLL, ";
                query += "'' AS E2_TITPIS, ";
                query += "'' AS E2_TITCOF, ";
                query += "'' AS E2_TITCSL, ";
                query += "'' AS E2_TITINS, ";
                query += "'0' AS E2_VRETPIS, ";
                query += "'0' AS E2_VRETCOF, ";
                query += "'0' AS E2_VRETCSL, ";
                query += "'' AS E2_PRETPIS, ";
                query += "'' AS E2_PRETCOF, ";
                query += "'' AS E2_PRETCSL, ";
                query += "'' AS E2_SEQBX, ";
                query += "'' AS E2_CODBAR, ";
                query += "F1_BASCOFI AS E2_BASECOF, ";
                query += "F1_BASPIS AS E2_BASEPIS, ";
                query += "F1_BASCSLL AS E2_BASECSL, ";
                query += "F1_ISS AS E2_VRETISS, ";
                query += "'' AS E2_VENCISS, ";
                query += "'0' AS E2_VBASISS, ";
                query += "'1' AS E2_MDRTISS, ";
                query += "'0' AS E2_VARIAC, ";
                query += "'' AS E2_PERIOD, ";
                query += "'' AS E2_MDCONTR, ";
                query += "'' AS E2_MDREVIS, ";
                query += "'' AS E2_MDPLANI, ";
                query += "'' AS E2_MDCRON, ";
                query += "'' AS E2_MDPARCE, ";
                query += "'1' AS E2_FRETISS, ";
                query += "'0' AS E2_TXMDCOR, ";
                query += "'1' AS E2_APLVLMN, ";
                query += "'' AS E2_CLEARIN, ";
                query += "'' AS E2_HORASPB, ";
                query += "'' AS E2_PRETIRF, ";
                query += "'' AS E2_SEFIP, ";
                query += "'' AS E2_TRETISS, ";
                query += "'0' AS E2_VRETIRF, ";
                query += "'' AS E2_PLOPELT, ";
                query += "'' AS E2_CODRDA, ";
                query += "'' AS E2_PARCFET, ";
                query += "'0' AS E2_FETHAB, ";
                query += "'' AS E2_FORORI, ";
                query += "'' AS E2_LOJORI, ";
                query += "'' AS E2_STATUS, ";
                query += "'' AS E2_DTDIRF, ";
                query += "'' AS E2_TITADT, ";
                query += "'' AS E2_TITPAI, ";
                query += "F1_INSS AS E2_INSSRET, ";
                query += "'' AS E2_CODAGL, ";
                query += "'' AS E2_PROCPCC, ";
                query += "'' AS E2_FORNPAI, ";
                query += "'' AS E2_CODISS, ";
                query += "'' AS E2_USUASUS, ";
                query += "'' AS E2_USUACAN, ";
                query += "'' AS E2_DATASUS, ";
                query += "'' AS E2_DATACAN, ";
                query += "'' AS E2_LIMCAN, ";
                query += "'' AS E2_PREOP, ";
                query += "'" + vDup +"' AS E2_BASEISS, ";
                query += "'' AS E2_NUMPRO, ";
                query += "'' AS E2_INDPRO, ";
                query += "'' AS E2_PARCAGL, ";
                query += "'' AS E2_NODIA, ";
                query += "'' AS E2_DIACTB, ";
                query += "'0' AS E2_MDMULT, ";
                query += "'0' AS E2_MDBONI, ";
                query += "'0' AS E2_MDDESC, ";
                query += "'0' AS E2_RETCNTR, ";
                query += "'0' AS E2_CIDE, ";
                query += "'' AS E2_PRETINS, ";
                query += "'' AS E2_VRETINS, ";
                query += "'' AS E2_FATFOR, ";
                query += "'' AS E2_FATLOJ, ";
                query += "'" + vDup + "' AS E2_BASEIRF, ";
                query += "F1_EMISSAO AS E2_DATAAGE, ";
                query += "'2' AS E2_TEMDOCS, ";
                query += "'01' AS E2_STATLIB, ";
                query += "'' AS E2_CODAPRO, ";
                query += "'' AS E2_IDMOV, ";
                query += "F1_INSS AS E2_PRINSS, ";
                query += "F1_BASEINS AS E2_BASEINS, ";
                query += "'' AS E2_PARCCID, ";
                query += "'' AS E2_CODRCSL, ";
                query += "'' AS E2_CODRPIS, ";
                query += "'' AS E2_CODRCOF, ";
                query += "'' AS E2_TIPOLIQ, ";
                query += "'' AS E2_PARIMP5, ";
                query += "'' AS E2_PARIMP4, ";
                query += "'' AS E2_PARIMP3, ";
                query += "'' AS E2_PARIMP2, ";
                query += "'' AS E2_PARIMP1, ";
                query += "'' AS E2_CODINS, ";
                query += "'' AS E2_IDDARF, ";
                query += "'' AS E2_DTBORDE, ";
                query += "F1_MSIDENT AS E2_MSIDENT, ";
                query += "'0' AS E2_PRISS, ";
                query += "'' AS E2_RATFIN, ";
                query += "'' AS E2_NUMSOL, ";
                query += "'' AS E2_CODOPE, ";
                query += "'0' AS E2_FABOV, ";
                query += "'0' AS E2_FACS, ";
                query += "'' AS E2_PARCFAB, ";
                query += "'' AS E2_PARCFAC, ";
                query += "'' AS E2_FIMP, ";
                query += "'' AS E2_NFELETR, ";
                query += "'' AS E2_AGLIMP, ";
                query += "'' AS D_E_L_E_T_, ";
                query += "ISNULL((SELECT MAX(R_E_C_N_O_)+1 FROM SE2" + nota.CodEmpErp + "0), 1) AS R_E_C_N_O_, ";
                query += "'0' AS R_E_C_D_E_L_, ";
                query += "'0' AS E2_FAMAD, ";
                query += "'' AS E2_PARCFAM, ";
                query += "'0' AS E2_FMPEQ, ";
                query += "'' AS E2_PARCFMP, ";
                query += "'' AS E2_FORBCO, ";
                query += "'' AS E2_FORAGE, ";
                query += "'' AS E2_FAGEDV, ";
                query += "'' AS E2_FORCTA, ";
                query += "'' AS E2_FCTADV ";
                query += "from " + nota.TabSF1 + " where F1_CHVNFE = '" + nota.ChaveNfe + "';";
            }
            return query;
        }

        //Função utilizada para cifrar a senha
        public static string getMD5Hash(string input)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }


    }
}
