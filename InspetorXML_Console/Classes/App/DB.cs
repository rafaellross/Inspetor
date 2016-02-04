using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspetorXML_Console.Classes
{
    class DB
    {
        public string connetionString { get; set; }
        private SqlConnection connection { get; set; }
        public System.IO.StreamWriter arquivoLog { get; set; }
        public string tipoDB { get; set; }
        public DB(string Instancia, string Banco, string Usuario, string Senha, string pastaLog, string tipoDB)
        {
            this.connetionString = "Data Source=" + Instancia + ";Initial Catalog=" + Banco + ";User ID=" + Usuario + ";Password=" + Senha + ";MultipleActiveResultSets=True";
            this.connection = new SqlConnection(this.connetionString);
            this.tipoDB = tipoDB;
            arquivoLog = new System.IO.StreamWriter(pastaLog + "Erros_DB_" + tipoDB +".txt");            
        }

        public bool abreConexao()
        {
            try
            {
                if (this.connection != null && this.connection.State == ConnectionState.Closed)
                {
                    this.connection.Open();
                }

                return true;
            }
            catch (Exception e)
            {
                this.arquivoLog.WriteLine("Ocorreu um erro ao conectar:" + e.ToString());            
                return false;
            }

        }

        public void fechaConexao()
        {
            try
            {
                this.connection.Close();
            }
            catch (Exception e)
            {
                this.arquivoLog.WriteLine("Ocorreu um erro ao fechar a conexão:" + e.ToString());                                
            }

        }

        public ArrayList consulta(string query)
        {
            ArrayList result = new ArrayList();
            try
            {
                this.abreConexao();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                SqlDataReader Dr = cmd.ExecuteReader();

                Dictionary<String, Object> dict = new Dictionary<string, object>();

                while (Dr.Read())
                {
                    for (int i = 0; i < (Dr.FieldCount - 1); i++)
                    {
                        dict.Add(Dr.GetName(i), Dr.GetString(i));
                    }
                    result.Add(dict);
                }
            }
            catch (Exception)
            {
                result.Add("erro");
            }
            
            return result;
        }

    }
}
