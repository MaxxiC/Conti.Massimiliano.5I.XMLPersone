using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Conti.Massimiliano._5I.XMLPersone
{
    class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Indirizzo { get; set; }
        public string NumeroDiTelefono { get; set; }

        public Persona(XElement Uno)
        {
            Nome = Uno.Attribute("Nome").Value;
            Cognome = Uno.Attribute("Cognome").Value;
            Indirizzo = Uno.Attribute("Indirizzo").Value;
            NumeroDiTelefono = Uno.Attribute("Numero").Value;
        }
    }
}
