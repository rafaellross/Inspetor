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
        public string caminhoProcessar { get; set; }
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
            return Directory.GetFiles(this.caminhoProcessar);
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
            foreach (var item in DocsXml())
            {
                XmlNfe nfe = new XmlNfe(this.tipoErp, item.Key, item.Value, "nfe", this.dbXml, this.dbErp);
                nfe.carregaAtributos();
                arquivosXml.Add(nfe);
            }
        }
    }
}
