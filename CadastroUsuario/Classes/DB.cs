using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
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
        public DB(string Instancia, string Banco, string Usuario, string Senha, StreamWriter arquivoLog, string tipoDB)
        {
            this.connetionString = "Data Source=" + Instancia + ";Initial Catalog=" + Banco + ";User ID=" + Usuario + ";Password=" + Senha + ";MultipleActiveResultSets=True";
            this.connection = new SqlConnection(this.connetionString);
            this.tipoDB = tipoDB;
            this.arquivoLog = arquivoLog;
        }

        public DB(string Instancia, string Banco, string Usuario, string Senha)
        {
            this.connetionString = "Data Source=" + Instancia + ";Initial Catalog=" + Banco + ";User ID=" + Usuario + ";Password=" + Senha + ";MultipleActiveResultSets=True";
            this.connection = new SqlConnection(this.connetionString);
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
                Console.ForegroundColor = System.ConsoleColor.Red;
                Console.WriteLine("Ocorreu um erro ao conectar:" + e.ToString());
                //this.arquivoLog.WriteLine("Ocorreu um erro ao conectar:" + e.ToString());
                Console.ForegroundColor = System.ConsoleColor.Gray;
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
                Console.WriteLine("Ocorreu um erro ao conectar:" + e.ToString());
                //this.arquivoLog.WriteLine("Ocorreu um erro ao fechar a conexão:" + e.ToString());
                Console.ForegroundColor = System.ConsoleColor.Gray;

                //this.arquivoLog.WriteLine("Ocorreu um erro ao fechar a conexão:" + e.ToString());                                
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
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = System.ConsoleColor.Red;
                Console.WriteLine("Erro no banco de dados:" + ex.ToString());
                //this.arquivoLog.WriteLineAsync("Erro no banco de dados:" + ex.ToString());
                Console.ForegroundColor = System.ConsoleColor.Gray;
            }
            finally
            {
                this.connection.Close();
            }
            return result;
        }

        public bool execQuery(string query)
        {            
            try
            {                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.connection;
                if (this.connection.State == ConnectionState.Closed)
                {
                    this.connection.Open();
                }                
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = System.ConsoleColor.Red;
                Console.WriteLine("Erro no banco de dados:" + ex.ToString());
                Console.ForegroundColor = System.ConsoleColor.Gray;
                return false;
            }
            finally
            {
                if (this.connection.State != ConnectionState.Closed)
                {
                    this.connection.Close();
                }                
            }            
        }
    }
}
