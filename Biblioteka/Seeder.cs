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

        public static Utente generateUtente()
        {
            string[] Nomi = { "Bensi", "Lollo", "Martina", "Prassitele", "Dario", "Ajeje", "Remo" , "Cataldo" , "Gino" , "Michele", "Amiele", "Costantino", "Il Dvce", "Adolf", "Diabolik", "Django", "Marpione", "Grifone", "Crillin", "Tasso" };
            string[] Cognomi = { "Il Vecchio", "Ambrogi", "Brosio", "Brazorrf", "Calen", "Garpelli", "Baglio", "Codeluppi", "Fumagalli", "Brambilla", "Azzeccagarbugli", "Beneventi", "Mussolini", "Hitler", "Freeman", "Zoolander", "Supreme", "Barcone", "Profugo", "Minestra" };
            string[] CodiciFiscali = { "MHATSY58D57U384J", "TYWHCK95F65S834J", "LAJEMH36H12N374F", "PWIENCJ45I73G465H", "EIRJRR85S75H693", "KEKEKE94W04N285H", "MAOCNR04H83N847K", "IUEHCN74D85X836F", "PSHNCY84C86O163G", "YRCLRM19C75H910S", "LMECYH10F73N285T", "MXNGTJ81Z95V736R", "ORPCNG84B65N174Z", "XMCNVB29M35C928N", "IRNCNG10X37D589L", "TEOTNO12N19M482H", "MEJCFR29C70C947L", "QAHZTE58C19D396A", "MCYTHD84N67S958P", "ASXNPW03C86S872O" };
            DateTime birth = new DateTime(rnd.Next(1940, 2010), rnd.Next(1, 12), rnd.Next(1, 28));

            return new Utente(Nomi[rnd.Next(0, 19)], Cognomi[rnd.Next(0, 19)], CodiciFiscali[rnd.Next(0, 19)], birth);
        }

        public static Libro generateLibro()
        {
            string[] Titoli = { "Giovanna Manganaro - le Cronache", "A funghi con Ertu", "Anatomia del collo di Maurizio Costanzo", "Spongebob vs Patrik: la resa dei conti", "Chompy scopre il petrolio", "Annona 2000", "il Regno dei Barzotti", "Autarchia: come ottenerla", "Brando porta da bere", "Le Memorie del Tortello", "", "Nasello va a segno", "", "Geronimo Stilton Barzellette Vol. 3", "Adelante Pdero, con juicio", "Bonificando le palvdi", "Come fare vela con il naso di Chiellinni", "Quando i treni arrivavano in orario", "La Storia di Brosco", "Un cane vestito da boscaiolo" };
            string[] Autori = {"G. Pube", "J. Jennaro", "P. Brancaleone", "S. Zancudo", "R. Pescatore", "D. Zoppo", "L. Buio", "M. Melagrano", "G.G. de la Tourette", "C. Lamantino", "K. Ermellini", "A. Carruba", "T. Ciompi", "Dark Polo Gang", "Z. Efron", "Lvi", "B. Foschia", "D. Brullo", "E. Polipotti", "L. Zangrullo" };
            string[] Generi = { "Giallo", "Avventura", "Azione", "Thriller", "Storico", "Fantascienza", "Guerra", "Per Ragazzi", "Scienitifico", "Horror", "Biografia", "Narrativa", "Poesia", "Commedia", "Romantico" };
            string[] Isbn = {"183939hd54", "7383935hg57", "378593sv23", "689949vc34", "473829hg82", "038475bd43", "757883gh76", "175827ms84", "758393hf75", "198472uh13", "287494ve71", "773939hf90", "827595ap53", "654635yw45", "934983gr39", "758748hj63", "908134yt28", "897873rr49", "177137oc83", "684983yn29" };

            return new Libro(Titoli[rnd.Next(0, 19)], Autori[rnd.Next(0, 19)], Generi[rnd.Next(0, 14)], Isbn[rnd.Next(0, 19)]);
        }
    }
}
