using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasseRum NyKlasse = new KlasseRum("3B", new List<Studerende>(), new DateTime (2018, 9, 4));
            NyKlasse.Klasseliste.Add(new Studerende ("Daniel", 3, 12));
            NyKlasse.Klasseliste.Add(new Studerende("Sander", 4, 13));
            NyKlasse.Klasseliste.Add(new Studerende("Nadia", 12, 14));
            NyKlasse.Klasseliste.Add(new Studerende("Søren", 7, 27));
            NyKlasse.Klasseliste.Add(new Studerende("Kian", 13, 28));

            Console.WriteLine(NyKlasse.Klassenavn);
            Console.WriteLine(NyKlasse.Semesterstart);
            foreach (Studerende item in NyKlasse.Klasseliste)
            {
                Console.WriteLine(item);
            }

            var forår = from stud in NyKlasse.Klasseliste
                where stud.Fødselsmåned == 3 || stud.Fødselsmåned == 4 || stud.Fødselsmåned == 5
                select stud;
            Console.WriteLine("Studerende m. fødselsdag om foråret " + forår.Count());
            var vinter = from stud in NyKlasse.Klasseliste
                where stud.Fødselsmåned == 1 || stud.Fødselsmåned == 2 || stud.Fødselsmåned == 12
                select stud;
            Console.WriteLine("Studerende m. fødselsdag om vinteren " + vinter.Count());
            var efterår = from stud in NyKlasse.Klasseliste
                where stud.Fødselsmåned == 9 || stud.Fødselsmåned == 10 || stud.Fødselsmåned == 11
                select stud;
            Console.WriteLine("Studerende m. fødselsdag om efteråret " + efterår.Count());
            var sommer = from stud in NyKlasse.Klasseliste
                where stud.Fødselsmåned == 6 || stud.Fødselsmåned == 7 || stud.Fødselsmåned == 8
                select stud;
            Console.WriteLine("Studerende m. fødselsdag om sommeren " + sommer.Count());
        }
    }
}
