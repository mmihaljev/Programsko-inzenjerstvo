using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autobusna_karta
{
    internal class Linija
    {
        public string _Polaziste, _Odrediste;
        public int _Udaljenost;

        public Linija( string polaziste, string odrediste, int udaljenost)
        {
            _Polaziste = polaziste;
            _Odrediste = odrediste;
            _Udaljenost = udaljenost;
        }
    }
}
