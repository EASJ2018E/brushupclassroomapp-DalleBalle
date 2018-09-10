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

        public override string ToString()
        {
            return _navn + " " + _fødselsdag + " " + _fødselsmåned;
        }

        public string Årstid()
        {
            switch (_fødselsmåned)
            {
                case int _fødselsmåned when _fødselsmåned == 1:
                    return "Vinter";
                case int _fødselsmåned when _fødselsmåned == 2:
                    return "Vinter";
                case int _fødselsmåned when _fødselsmåned == 3:
                    return "Forår";
                case int _fødselsmåned when _fødselsmåned == 4:
                    return "Forår";
                case int _fødselsmåned when _fødselsmåned == 5:
                    return "Forår";
                case int _fødselsmåned when _fødselsmåned == 6:
                    return "Sommer";
                case int _fødselsmåned when _fødselsmåned == 7:
                    return "Sommer";
                case int _fødselsmåned when _fødselsmåned == 8:
                    return "Sommer";
                case int _fødselsmåned when _fødselsmåned == 9:
                    return "Efterår";
                case int _fødselsmåned when _fødselsmåned == 10:
                    return "Efterår";
                case int _fødselsmåned when _fødselsmåned == 11:
                    return "Efterår";
                case int _fødselsmåned when _fødselsmåned == 12:
                    return "Vinter";
            }
        }
    }
}
