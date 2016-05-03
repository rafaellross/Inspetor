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
    public class DB
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
                this.arquivoLog.WriteLineAsync("Ocorreu um erro ao conectar:" + e.ToString());
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
                this.arquivoLog.WriteLine("Ocorreu um erro ao fechar a conexão:" + e.ToString());
                Console.ForegroundColor = System.ConsoleColor.Gray;

                this.arquivoLog.WriteLineAsync("Ocorreu um erro ao fechar a conexão:" + e.ToString());                                
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
                Console.WriteLine(query);
                Console.WriteLine("Erro no banco de dados:" + ex.ToString());
                this.arquivoLog.WriteLineAsync("Erro no banco de dados:" + ex.ToString());
                Console.ForegroundColor = System.ConsoleColor.Gray;
            }
            finally
            {
                this.connection.Close();
            }
            return result;
        }

        public ArrayList execQuery(string query)
        {
            ArrayList result = new ArrayList();
            try
            {                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.connection;
                if (this.connection.State == ConnectionState.Closed)
                {
                    this.connection.Open();
                }
                
                cmd.CommandText = query;
                SqlDataReader Dr = cmd.ExecuteReader();

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = System.ConsoleColor.Red;
                Console.WriteLine(query);
                Console.WriteLine("Erro no banco de dados:" + ex.ToString());
                Console.ForegroundColor = System.ConsoleColor.Gray;
                this.arquivoLog.WriteLineAsync("Erro no banco de dados:" + ex.ToString());
                result.Add("erro: " + ex.ToString());
            }
            finally
            {
                if (this.connection.State != ConnectionState.Closed)
                {
                    this.connection.Close();
                }

                
            }
            return result;
        }

        public List<Dictionary<string, string>> queryListToDic(string query)
        {
            List<Dictionary<string, string>> result = new List<Dictionary<string, string>>();
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.connection;
                this.connection.Open();
                cmd.CommandText = query;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var dict = new Dictionary<string, string>();
                    for (int i = 0; i <= dr.FieldCount - 1; i++)
                    {
                        dict.Add(dr.GetName(i), dr.GetValue(i).ToString());
                    }
                    result.Add(dict);
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = System.ConsoleColor.Red;                                
                var erro = new Dictionary<string, string>();                
                var msgErro = "---------------------------------------------------------------------" + "\n";
                msgErro += "Comando: " + "\n";
                msgErro += query + "\n";
                msgErro += "Mensagem: " + "\n";
                msgErro += ex.Message + "\n";
                msgErro += "---------------------------------------------------------------------" + "\n";
                Console.WriteLine(msgErro);
                this.arquivoLog.WriteLineAsync(msgErro);
                Console.ForegroundColor = System.ConsoleColor.Gray;
                erro.Add("erro", ex.Message);
                result.Add(erro);
            }
            finally
            {
                if (this.connection.State != ConnectionState.Closed)
                {
                    this.connection.Close();
                }
            }

            return result;
        }

        public bool insere(string query, string nomeTransacao = "InsertNotas")
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = this.connection;
            this.connection.Open();
            SqlTransaction transac = connection.BeginTransaction(nomeTransacao);
            cmd.Transaction = transac;
            try
            {
                cmd.CommandText = query;                
                cmd.ExecuteNonQuery();
                transac.Commit();
                return true;
            }
            catch (Exception ex)
            {
                try
                {
                    transac.Rollback(nomeTransacao);
                }
                catch (Exception ex2)
                {
                    // This catch block will handle any errors that may have occurred
                    // on the server that would cause the rollback to fail, such as
                    // a closed connection.
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                    Console.WriteLine("  Message: {0}", ex2.Message);
                }
                
                Console.ForegroundColor = System.ConsoleColor.Red;                                
                var msgErro = "---------------------------------------------------------------------" + "\n";
                    msgErro += "Comando: " + "\n";
                    msgErro += query + "\n";
                    msgErro += "Mensagem: " + "\n";
                    msgErro += ex.Message + "\n";
                    msgErro += "---------------------------------------------------------------------" + "\n";
                Console.WriteLine(msgErro);
                this.arquivoLog.WriteLineAsync(msgErro);
                Console.ForegroundColor = System.ConsoleColor.Gray;
                return false;
            }
            finally
            {
                this.connection.Close();
            }            
        }

    }
}
