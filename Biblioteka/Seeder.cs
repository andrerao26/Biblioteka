using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    static class Seeder
    {
        static Random rnd = new Random();

        public static void generateUtenti(ListBox lb)
        {
            int amount = 20;
            string[] arrayNomi = { "Bensi", "Lollo", "Martina", "Lorenzo", "Dario", "Ajeje", "Remo" , "Cataldo" , "Gino" , "Michele" };
            string[] arrayCognomi = { "Il Vecchio", "Ambrogi", "Brosio", "Brazorrf", "Calen", "Garpelli", "Baglio", "Codeluppi", "Fumagalli", "Brambilla" };
            string[] arrayCodiceFiscale = { "h5h5i4ihi5", "kk8koo3k5", "a99a9aa77a", "a1a1aaa33", "mlm5m5m5", "jjj5uu6u", "3nkn5k3n5k", "llmcnnc44", "3jh554h4", "mccbhi8x88" };
            DateTime birth = new DateTime(rnd.Next(1940, 2010), rnd.Next(1, 12), rnd.Next(1, 31));

            for (int i = 0; i < amount; i++)
            {
                Utente user = new Utente(arrayNomi[rnd.Next(0, 9)], arrayCognomi[rnd.Next(0, 9)], arrayCodiceFiscale[rnd.Next(0, 9)], birth);
                lb.Items.Add(user);
            }
        }

        public static void generateLibri(ListBox lb)
        {
            int amount = 20;
            string[] arrayTitoli = {"Kappone", "Martozzo", "Pappelo", "Turtume", "Sacchino", "Jeppetto", "Battanza", "Riccheria", "Candelante", "Zoggello" };
            string[] arrayAutori = {"G. Pube", "M. Sanniene", "P. Caldo", "G. Freddo", "S. Mascherone", "D. Zoppo", "L. Buio", "M. Wytty", "T. Turette", "A. Campodidio" };
            string[] arrayGeneri = { "Giallo", "Avventura", "Azione", "Thriller", "Storico", "Fantascienza", "Guerra", "Per Ragazzi", "Scienitifico", "Horror", "Biografia", "Narrativa", "Poesia" };
            string[] arrayIsbn = {"hhh554h545", "kkk6k6k6", "a7a7a7a7", "bb5bbbb6bb6", "a9a989a8a3", "l4l4ll54ll", "s33s44s3", "vvv0v0v90v", "w32232333", "11a11a11a" };

            for (int i = 0; i < amount; i++)
            {
                Libro book = new Libro(arrayTitoli[rnd.Next(0, 9)], arrayAutori[rnd.Next(0, 9)], arrayGeneri[rnd.Next(0, 9)], arrayIsbn[rnd.Next(0, 9)]);
                lb.Items.Add(book);
            }
        }
    }
}
