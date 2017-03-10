using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    static class Seeder
    {
        public static void generateUtenti()
        {
            string[] arrayNomi = { "Bensi", "Lollo", "Martina", "Lorenzo", "Dario", "Ajeje", "Remo" , "Cataldo" , "Gino" , "Michele" };
            string[] arrayCognomi = { "Il Vecchio", "Ambrogi", "Brosio", "Brazorrf", "Calen", "Garpelli", "Baglio", "Codeluppi", "Fumagalli", "Brambilla" };
        }

        public static void generateLibri()
        {
            string[] arrayTitoli = { };
            string[] arrayAutori = { };
            string[] arrayGeneri = { "Giallo", "Avventura", "Azione", "Thriller", "Storico", "Fantascienza", "Guerra", "Ragazzi", "Scienitifico", "Horror", "Biografia", "Narrativa", "Poesia" };
        }
    }
}
