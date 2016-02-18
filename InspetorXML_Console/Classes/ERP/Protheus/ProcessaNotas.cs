using InspetorXML_Console.Classes.XML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspetorXML_Console.Classes.ERP.Protheus
{
    class ProcessaNotas
    {
        public List<XmlNfe> notas { get; private set; }

        public ProcessaNotas(List<XmlNfe> notas)
        {
            this.notas = notas;
        }

        
    }
}
