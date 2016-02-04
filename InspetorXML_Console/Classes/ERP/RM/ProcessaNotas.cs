using InspetorXML_Console.Classes.XML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InspetorXML_Console.Classes.Generico;

namespace InspetorXML_Console.Classes.ERP.RM
{
    class ProcessaNotas : ERP.Generico.Erp, FuncoesErp
    {
        public List<XmlNfe> notas { get; private set; }

        public ProcessaNotas(List<XmlNfe> notas)
        {
            this.notas = notas;
        }

        public void teste()
        {
            throw new NotImplementedException();
        }
    }
}
