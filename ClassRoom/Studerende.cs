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

        public Studerende(string navn, int måned, int dag)
        {
            this._navn = navn;
            this._fødselsmåned = måned;
            this._fødselsdag = dag;
        }

        public string Navn
        {
            get { return _navn; }
        }

        public int Fødselsmåned
        {
            get { return _fødselsmåned; }
        }

        public int Fødselsdag
        {
            get { return _fødselsdag; }
        }
    }
}
