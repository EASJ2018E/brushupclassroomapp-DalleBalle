using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class KlasseRum
    {
        private string _klassenavn;
        private List<Studerende> _klasseliste;
        private DateTime _semesterstart;

        public KlasseRum(string klassenavn, List<Studerende> klasseliste, DateTime semesterstart)
        {
            this._klassenavn = klassenavn;
            this._klasseliste = klasseliste;
            this._semesterstart = semesterstart;
        }

        public string Klassenavn
        {
            get { return _klassenavn; }
        }

        public List<Studerende> Klasseliste
        {
            get { return _klasseliste; }
        }

        public DateTime Semesterstart
        {
            get { return _semesterstart; }
        }
    }
}
