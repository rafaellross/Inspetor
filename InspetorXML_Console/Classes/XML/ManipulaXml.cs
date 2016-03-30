﻿using InspetorXML_Console.Classes.App;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace InspetorXML_Console.Classes.XML
{
    class ManipulaXml
    {
        public Parametros parametros { get; set; }
        public string[] arquivos { get; set; }
        public List<XmlNfe> arquivosXml { get; set; }
        public DB dbXml { get; set; }
        public DB dbErp { get; set; }
        public string tipoErp { get; private set; }

        public ManipulaXml(string tipoErp, DB dbXml, DB dbErp)
        {
            this.arquivosXml = new List<XmlNfe>();
            this.dbXml = dbXml;
            this.dbErp = dbErp;
            this.tipoErp = tipoErp;

        }
        //Este método lê o diretório e retorna o nome de todos os arquivos
        public string[] lerDiretorio()
        {
            return Directory.GetFiles(this.parametros.PastaProcessar);
        }

        //Retorna uma lista de arquivos XML lidos no método lerDiretorio
        public Dictionary<string, string> DocsXml()
        {
            var dict = new Dictionary<string, string>();

            

            foreach (var DocXml in this.lerDiretorio())
            {
                dict.Add(DocXml, DocXml);
            }
            return dict;
        }

        public void carregaXml()
        {
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            if (DocsXml().Count == 0)
            {
                Console.ForegroundColor = System.ConsoleColor.Blue;
                Console.WriteLine("    A pasta de processamento está vazia");
                Console.ForegroundColor = System.ConsoleColor.Gray;
            }
            else
            {
                Console.WriteLine("Foram encontrados " + DocsXml().Count.ToString() + " arquivos XML na pasta para processar");

                foreach (var item in DocsXml())
                {
                    Console.ForegroundColor = System.ConsoleColor.Green;
                    Console.WriteLine(" ");
                    Console.WriteLine("         Iniciando a manipulação do arquivo " + item.Key.ToString());
                    XmlNfe nfe = new XmlNfe(this.tipoErp, item.Key, item.Value, "nfe", this.dbXml, this.dbErp, parametros);
                    nfe.carregaAtributos();
                    arquivosXml.Add(nfe);
                    Console.WriteLine("         Arquivo " + item.Key.ToString() + " carregado");
                    Console.ForegroundColor = System.ConsoleColor.Gray;
                }

            }
        }
    }
}
