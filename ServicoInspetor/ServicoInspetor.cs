using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;

using System.Threading.Tasks;
using System.Timers;

namespace ServicoInspetor
{

    public partial class ServicoInspetor : ServiceBase
    {
        public ServicoInspetor()
        {
            InitializeComponent();
        }

        Timer timer = new Timer();
        

        protected override void OnStart(string[] args)
        {


            var parametros = ConfigurationManager.AppSettings;
            var tempoExecucao = parametros["TempoExecucao"];
            //Escreve no Visualizador de Evento do Windows
            
            EventLog.WriteEntry("Serviço Inicializado.", EventLogEntryType.Information);


            //1: Adicionando o evento Elapsed ao objeto Timer
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);

            //2: Marcando o como intervalo o campo do arquivo de configuração TempoExecucao
            timer.Interval = Convert.ToInt64(tempoExecucao)*1000;
            
            //3: Habilitando o objeto timer para execução.
            timer.Enabled = true;
        }

        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            EventLog.WriteEntry("Executando serviço: " +
                DateTime.Now.ToShortTimeString(), EventLogEntryType.Information);
            try
            {
                var startupPath = System.IO.Path.GetDirectoryName(
                       System.Reflection.Assembly.GetEntryAssembly().Location);
                var programPath = System.IO.Path.Combine(startupPath, "InspetorXML_Console.exe start");
                Process inspetorConsole = new Process();
                inspetorConsole.StartInfo.UseShellExecute = true;
                inspetorConsole.StartInfo.RedirectStandardOutput = true;
                inspetorConsole.StartInfo.FileName = programPath;
                inspetorConsole.Start();

            }
            catch (Exception ex)
            {

                EventLog.WriteEntry("InspetorXML" + ex.Message);
            }
                        
        }
        protected override void OnStop()
        {
            timer.Enabled = false;
            EventLog.WriteEntry("Serviço Parado.", EventLogEntryType.Information);
        }
    }
}
