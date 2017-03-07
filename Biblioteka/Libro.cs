using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Libro
    {
        //public enum genere { Giallo, Avventura, Azione, Thriller, Storico, Fantascienza, Guerra, Ragazzi, Scienitifico, Horror, Biografia, Narrativa };

        public string titolo { get; set; }

        public string autore { get; set; }

        public string genere { get; set; }

        public string isbn { get; set; }

        private bool _prestato;
        public bool prestato { get { return false; } }

        public Utente possessore { get; set; }

        public Libro(string titolo, string autore, string genere, string isbn)
        {
            this.titolo = titolo;
            this.autore = autore;
            this.genere = genere;
            this.isbn = isbn;
        }

        public string describeLibro()
        {
            string output = titolo + "\r\n" +
                            autore + "\r\n" +
                            genere + "\r\n" +
                            isbn + "\r\n";
            if (prestato)
            {
                output += "il libro non è attualmente in prestito \r\n";
            }
            else
            {
                output += "il libro è attualmente in prestito a " + possessore.nome;
            }

            return output;
        }

        public override string ToString()
        {
            return titolo + " " + isbn;
        }

        public bool prestaLibro(Utente user)
        {
            if (!prestato)
            {
                user.libriPrestito.Add(this);
                _prestato = true;

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
