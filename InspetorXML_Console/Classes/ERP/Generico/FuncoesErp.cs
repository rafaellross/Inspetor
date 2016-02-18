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
                return "SELECT M0_CODIGO, M0_CODFIL FROM SIGAMAT WHERE M0_CGC = '" + cnpjEmpresa + "'";
            }
            else
            {
                return "SELECT CODCOLIGADA, CODFILIAL FROM GFILIAL WHERE REPLACE(REPLACE(REPLACE(CGC, '.', ''), '/', ''), '-', '') = '" + cnpjEmpresa + "'"; ;
            }            
        }
    }
}
