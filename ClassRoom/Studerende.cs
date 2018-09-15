using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Studerende
    {
        private string _navn;
        private int _fødselsmåned;
        private int _fødselsdag;
        private string _årstid;

        public Studerende(string navn, int måned, int dag)
        {
            this._navn = navn;
            this.Fødselsmåned = måned;
            this._fødselsdag = dag;
            this._årstid = Årstidberegner.Årstid(Fødselsmåned);
        }

        public string Navn
        {
            get { return _navn; }
        }

        public int Fødselsmåned
        {
            get { return _fødselsmåned; }
            set
            {
                if (value < 1)
                {
                    _fødselsmåned = 1;
                }
                else if (value > 12)
                {
                    _fødselsmåned = 12;
                }
                else
                {
                    _fødselsmåned = value;
                }
            }
        }

        public int Fødselsdag
        {
            get { return _fødselsdag; }
        }

        public override string ToString()
        {
            return _navn + " " + _fødselsdag + " " + _fødselsmåned + " " + _årstid;
        }
    }
}
