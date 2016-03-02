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
        public SqlConnection connection { get; set; }
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

        public List<string> consultaErp(string query)
        {
            List<string> result = new List<string>();
            try
            {
                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.connection;
                this.connection.Open();
                cmd.CommandText = query;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    for (int i = 0; i <= dr.FieldCount-1; i++)
                    {
                        result.Add(dr.GetValue(i).ToString());
                    }                    
                }                
                return result;

            }
            catch (Exception)
            {                
                return result;
            }
            finally
            {
                this.connection.Close();
            }        
                        

        }

        public ArrayList execQuery(string query)
        {
            ArrayList result = new ArrayList();
            try
            {
                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.connection;
                this.connection.Open();
                cmd.CommandText = query;
                SqlDataReader Dr = cmd.ExecuteReader();

                
            }
            catch (Exception ex)
            {
                result.Add("erro: " + ex.ToString());
            }
            this.connection.Close();
            return result;
        }

    }
}
