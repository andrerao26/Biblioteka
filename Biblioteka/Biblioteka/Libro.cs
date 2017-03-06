using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Libro
    {
        public string titolo { get; set; }
        public string autore { get; set; }
        public enum genere { };
        public string isbn { get; set; }
        private bool _prestato;
        public bool prestato { get { return true; } }
        public Utente possessore { get; set; }

        public Libro()
        {

        }

        public string describeLibro()
        {
            return "qua descrivo il libro";
        }

        public override string ToString()
        {
            return titolo + " " + isbn;
        }

        public bool prestaLibro()
        {
            return true;
        }
    }
}
