using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using InspetorXML_Console.Classes;
using InspetorXML_Console.Classes.App;
using InspetorXML_Console.Classes.ERP.Generico;
using InspetorXML_Console.Classes.XML;
using System.IO;
using System.Configuration;
using System.Timers;
using System.Threading;

namespace ServicoTeste
{
    public partial class ServicoInspetor : ServiceBase
    {
        public ServicoInspetor()
        {
            InitializeComponent();
            this.ServiceName = "InspetorXML - Processamento NFe";            
        }

        public bool EmExecucao { get; set; } = false;

        System.Timers.Timer timer = new System.Timers.Timer();
        

        protected override void OnStart(string[] args)
        {
            var parametros = ConfigurationManager.AppSettings;
            var tempoExecucao = parametros["TempoExecucao"];
            //Escreve no Visualizador de Evento do Windows

            EventLog.WriteEntry("Serviço Inicializado.", EventLogEntryType.Information);


            //1: Adicionando o evento Elapsed ao objeto Timer
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);

            //2: Marcando o como intervalo o campo do arquivo de configuração TempoExecucao
            timer.Interval = 60000 * Convert.ToInt64(tempoExecucao);

            //3: Habilitando o objeto timer para execução.
            timer.Enabled = true;

            //iniciaInspetor();
            
        }

        protected override void OnStop()
        {
        }

        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            try
            {
                EventLog.WriteEntry("Serviço em execução.", EventLogEntryType.Information);
                iniciaInspetor();
                EventLog.WriteEntry("Finalizou a inclusão.", EventLogEntryType.Information);                
            }
            catch (Exception ex)
            {

                EventLog.WriteEntry("Erro no inspetor:" + ex.Message, EventLogEntryType.Error);
            }
            
        }

        public void iniciaInspetor()
        {
            //Verificar se o processamento já está em execução
            if (!this.EmExecucao)
            {

                //Instancia a classe dos parametros
                Parametros parametros = new Parametros();
                //Carrega os parâmetros do arquivo config            
                parametros.carregaParametros();

                parametros.criaPastas();

                StreamWriter logXml;
                StreamWriter logErp;
                var nomeArquivoLogErp = parametros.PastaLog + "\\Erros_DB_" + parametros.TipoErp + ".txt";
                var nomeArquivoLogXml = parametros.PastaLog + "\\Erros_DB_xml.txt";

                logXml = new StreamWriter(nomeArquivoLogXml);
                logErp = new StreamWriter(nomeArquivoLogErp);



                DB dbErp = new DB(parametros.DBErpServer, parametros.DBErp, parametros.UserDBErp, parametros.PasswdDBErp, logErp, parametros.TipoErp);
                DB dbInspetor = new DB(parametros.DBInspetorServer, parametros.DBInspetor, parametros.UserDBInspetor, parametros.PasswdDBInspetor, logXml, "InspetorXml");

                //Instancia a classe para manipulação dos arquivos XML
                ManipulaXml notas = new ManipulaXml(parametros.TipoErp, dbInspetor, dbErp);

                //Passa o caminho da pasta de processamento dos arquivos
                notas.parametros = parametros;

                //Carrega os arquivos XML

                notas.carregaXml();

                EventLog.WriteEntry("Serão processadas " + notas.arquivosXml.Count.ToString() + " notas!", EventLogEntryType.Information);
                

                if (notas.arquivosXml.Count == 0)
                {
                    Environment.Exit(0);
                }
                //Instanciando objeto do ERP para inserir das notas
                Erp erp = new Erp(notas.arquivosXml, dbErp, parametros, dbInspetor);
                erp.inicia();
                this.EmExecucao = false;
                logErp.Close();
                logXml.Close();
                
                notas = null;
                erp = null;
            }
            else
            {
                EventLog.WriteEntry("O processamento já estava em execução.", EventLogEntryType.Information);
            }
        }
    }
}
