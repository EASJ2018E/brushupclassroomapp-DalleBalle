using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public static class Årstidberegner
    {
        public static string Årstid(int måned)
        {
            string årstid = "";

            switch (måned)
            {
                case 1:
                case 2:
                case 12:
                    årstid = "Vinter";
                    break;
                case 3:
                case 4:
                case 5:
                    årstid = "Forår";
                    break;
                case 6:
                case 7:
                case 8:
                    årstid = "Sommer";
                    break;
                case 9:
                case 10:
                case 11:
                    årstid = "Efterår";
                    break;
                default:
                    årstid = "Ukendt årstid";
                    break;
            }

            return årstid;
        }
    }
}
