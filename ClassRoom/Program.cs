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
            NyKlasse.Klasseliste.Add(new Studerende("Nadia", 5, 14));
            NyKlasse.Klasseliste.Add(new Studerende("Søren", 9, 27));
            NyKlasse.Klasseliste.Add(new Studerende("Kian", 10, 28));

            Console.WriteLine(NyKlasse.Klassenavn);
            Console.WriteLine(NyKlasse.Semesterstart);
            foreach (Studerende item in NyKlasse.Klasseliste)
            {
                Console.WriteLine(item);
            }
        }
    }
}
