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

        public string genere { get; set; }

        public string isbn { get; set; }

        private bool _prestato;
        public bool prestato { get { return _prestato; } }

        private Utente _possessore;
        public Utente possessore { get { return _possessore; } }

        public Libro(string titolo, string autore, string genere, string isbn)
        {
            this.titolo = titolo;
            this.autore = autore;
            this.genere = genere;
            this.isbn = isbn;
            _prestato = false;
        }

        public string describeLibro()
        {
            string output = Environment.NewLine +
                            "Titolo: "      + titolo + Environment.NewLine +
                            "Autore: "      + autore + Environment.NewLine +
                            "Genere: "      + genere + Environment.NewLine +
                            "Codice ISBN: " + isbn   + Environment.NewLine +
                                                       Environment.NewLine;
            if (prestato)
            {
                output += "il libro è attualmente in prestito a " + possessore.ToString() + ". ";
            }
            else
            {
                output += "il libro non è attualmente in prestito. ";
            }

            return output;
        }

        public override string ToString()
        {
            return titolo + Environment.NewLine;
        }

        public bool prestaLibro(Utente user)
        {
            if (prestato) throw new Exception("Il libro è già stato prestato.");

            if (user.libriPrestito.Count >= 10) throw new Exception("L'utente ha raggiunto il massimo di 10 libri consentiti");

            user.libriPrestito.Add(this);
            _prestato = true;
            _possessore = user;
 
            return true;
        }
    }
}
