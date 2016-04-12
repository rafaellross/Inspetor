using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ExeConfigurationFileMap configMap = new ExeConfigurationFileMap();
            configMap.ExeConfigFilename = @"C:\\Program Files (x86)\\CMS Consultoria\\InspetorXML\\InspetorXML_Console.exe.config";
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configMap, ConfigurationUserLevel.None);
            var parametros = config.AppSettings.Settings;

            Console.WriteLine(parametros["TempoExecucao"].Value);
            if (Process.GetProcessesByName("InspetorXML_Console").Length > 0)
            {
                Console.WriteLine("O serviço já está em execução!");
            }


            Console.ReadKey();
        }
    }
}
