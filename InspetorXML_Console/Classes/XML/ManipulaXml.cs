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

        public ManipulaXml(DB dbXml, DB dbErp)
        {
            this.arquivosXml = new List<XmlNfe>();
            this.dbXml = dbXml;
            this.dbErp = dbErp;

        }
        //Este método lê o diretório e retorna o nome de todos os arquivos
        public string[] lerDiretorio()
        {
            return Directory.GetFiles(this.caminhoProcessar);
        }

        //Este método carrega um arquivo Xml a partir do caminho do arquivo
        public XmlDocument lerXml(string arquivo)
        {
            XmlDocument DocXml = new XmlDocument();
            DocXml.Load(arquivo);
            return DocXml;
        }

        //Retorna uma lista de arquivos XML lidos no método lerDiretorio
        public Dictionary<string, XmlDocument> DocsXml()
        {
            var dict = new Dictionary<string, XmlDocument>();

            

            foreach (var DocXml in this.lerDiretorio())
            {
                dict.Add(DocXml, this.lerXml(DocXml));
            }
            return dict;
        }

        public void carregaXml()
        {
            foreach (var item in DocsXml())
            {
                XmlNfe nfe = new XmlNfe(item.Key, item.Value, "nfe", this.dbXml, this.dbErp);
                nfe.carregaAtributos();
                arquivosXml.Add(nfe);
            }
        }
    }
}
