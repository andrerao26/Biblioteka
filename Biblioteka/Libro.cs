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

        public Utente possessore { get; set; }

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
            string output = "Titolo: " + titolo + "\r\n" +
                            "Autore: " + autore + "\r\n" +
                            "Genere: " + genere + "\r\n" +
                            "Codice ISBN: " + isbn + "\r\n";
            if (prestato)
            {
                output += "il libro è attualmente in prestito a " + possessore.nome + ". ";
            }
            else
            {
                output += "il libro non è attualmente in prestito. ";
            }

            return output;
        }

        public override string ToString()
        {
            return titolo + " " + isbn + "\r\n";
        }

        public bool prestaLibro(Utente user)
        {
            if (!prestato)
            {
                user.libriPrestito.Add(this);
                _prestato = true;
                possessore = user;

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
