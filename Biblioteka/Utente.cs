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

        public Utente(string nome, string cognome, string codiceFiscale, DateTime dataNascita)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.codiceFiscale = codiceFiscale;
            this.dataNascita = dataNascita;
        }

        public string describeUtente()
        {
            string data = dataNascita.Day.ToString() + "/" + dataNascita.Month.ToString() + "/" + dataNascita.Year.ToString();
            string output = "Nome: "            + nome           + "\r\n" +
                            "Cognome: "         + cognome        + "\r\n" +
                            "Codice fiscale: "  + codiceFiscale  + "\r\n" +
                            "Data di Nascita: " + data           + "\r\n" ;
            int count = libriPrestito.Count;
            switch (count)
            {
                case 0:
                    output += "l'utente non ha attualmente libri in prestito";
                    break;

                case 1:
                    output += "L'utente ha 1 libro in prestito.";
                    break;

                default:
                    output += "L'utente ha " + count + " libri in prestito.";
                    break;
            }
                            
            return output;
        }

        public override string ToString()
        {
            return nome + " " + cognome;
        }

        public string describeLibriPrestito()
        {
            string output = "";
            int l = libriPrestito.Count;
            for (int i = 0; i < l; i++)
            {
                output += libriPrestito[i].ToString();
            }

            return output;
        }
    }
}
