using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Utente
    {
        public string nome { get; set; }

        public string cognome { get; set; }

        public string codiceFiscale { get; set; }

        public DateTime dataNascita { get; set; }

        public List<Libro> libriPrestito = new List<Libro>();

        public Utente()
        {

        }

        public string describeUtente()
        {
            return "qua descrivo l'utente";
        }

        public override string ToString()
        {
            return nome + " " + cognome;
        }

        public string describeLibriPrestito()
        {
            return "qua descrivo tutti i libri in prestito all'utente";
        }
    }
}
