using InspetorXML_Console.Classes;
using InspetorXML_Console.Classes.App;
using InspetorXML_Console.Classes.ERP.Generico;
using InspetorXML_Console.Classes.XML;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace InspetorXML_Console
{
    class Program
    {

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        static extern bool SetLayeredWindowAttributes(IntPtr hWnd, uint crKey, byte bAlpha, uint dwFlags);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern IntPtr GetConsoleWindow();

        static void Main(string[] args)
        {
            Console.Title = "Processamento - InspetorXML";

            //Configura transparência do console

            int GWL_EXSTYLE = -20;
            int WS_EX_LAYERED = 0x80000;
            uint LWA_ALPHA = 0x2;

            // Obtain our handle (hWnd)
            IntPtr Handle = GetConsoleWindow();
            SetWindowLong(Handle, GWL_EXSTYLE, GetWindowLong(Handle, GWL_EXSTYLE) ^ WS_EX_LAYERED);
            // Opacity = 0.5 = (255/2)
            SetLayeredWindowAttributes(Handle, 0, 245, LWA_ALPHA);
            //Instancia a classe dos parametros
            Parametros parametros = new Parametros();
            //Carrega os parâmetros do arquivo config
            Console.WriteLine("Carrega os Parametros");
            parametros.carregaParametros();

            //Console.WindowWidth = 140;
            //Console.WindowHeight = 40;
            Console.WriteLine("Cria as variáveis dos arquivos de log");
            StreamWriter logXml;
            StreamWriter logErp;
            if (!File.Exists(parametros.PastaLog + "\\Erros_DB_xml.txt"))
            {
                logXml = new StreamWriter(parametros.PastaLog + "\\Erros_DB_xml.txt");
                logErp = new StreamWriter(parametros.PastaLog + "\\Erros_DB_" + parametros.TipoErp + ".txt");
            }
            else
            {
                logXml = File.AppendText(parametros.PastaLog + "\\Erros_DB_xml.txt");                    
                logErp = File.AppendText(parametros.PastaLog + "\\Erros_DB_" + parametros.TipoErp + ".txt");
            }
            Console.WriteLine("Log DB XML:" + logXml + " | " + "Log DB Erp:" + logErp.ToString());
            Console.WriteLine(" ");
            Console.WriteLine(" ");



            Console.WriteLine("Instancia os Bancos de Dados");
            //public DB(string Instancia, string Banco, string Usuario, string Senha, StreamWriter arquivoLog, string tipoDB)
            
            DB dbErp = new DB(parametros.DBErpServer, parametros.DBErp, parametros.UserDBErp, parametros.PasswdDBErp, logErp, parametros.TipoErp);
            DB dbInspetor = new DB(parametros.DBInspetorServer, parametros.DBInspetor, parametros.UserDBInspetor, parametros.PasswdDBInspetor, logXml, "InspetorXml");

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Criando objeto para manipulação dos arquivos XML");
            //Instancia a classe para manipulação dos arquivos XML
            ManipulaXml notas = new ManipulaXml(parametros.TipoErp, dbInspetor, dbErp);


            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Passa o caminho da pasta de processamento dos arquivos");
            //Passa o caminho da pasta de processamento dos arquivos
            notas.parametros = parametros;

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Carrega os arquivos XML");
            //Carrega os arquivos XML
            
            notas.carregaXml();

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            if (notas.arquivosXml.Count == 0)
            {
                Console.WriteLine("Aperte qualquer tecla para sair!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("Instanciando objeto do ERP para inserir das notas");

            //Instanciando objeto do ERP para inserir das notas
            Erp erp = new Erp(notas.arquivosXml, dbErp, parametros, dbInspetor);
            erp.inicia();
            Console.ReadLine();            


        }
    }
}
