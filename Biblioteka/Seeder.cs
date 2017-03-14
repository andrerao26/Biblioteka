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
            string[] arrayCodiceFiscale = { };
            DateTime birth = new DateTime(rnd.Next(1940, 2010), rnd.Next(1, 12), rnd.Next(1, 31));

            for (int i = 0; i < amount; i++)
            {
                Utente user = new Utente(arrayNomi[rnd.Next(0, 9)], arrayCognomi[rnd.Next(0, 9)], arrayCodiceFiscale[rnd.Next()], birth);
                lb.Items.Add(user);
            }
        }

        public static void generateLibri(ListBox lb)
        {
            int amount = 20;
            string[] arrayTitoli = { };
            string[] arrayAutori = { };
            string[] arrayGeneri = { "Giallo", "Avventura", "Azione", "Thriller", "Storico", "Fantascienza", "Guerra", "Per Ragazzi", "Scienitifico", "Horror", "Biografia", "Narrativa", "Poesia" };
            string[] arrayIsbn = { };

            for (int i = 0; i < amount; i++)
            {
                Libro book = new Libro(arrayTitoli[rnd.Next()], arrayAutori[rnd.Next(0, 9)], arrayGeneri[rnd.Next()], arrayIsbn[rnd.Next()]);
                lb.Items.Add(book);
            }
        }
    }
}
