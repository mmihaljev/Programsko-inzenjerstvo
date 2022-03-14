using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kucna_knjiznica_2
{
    internal class Knjiga
    {
        public string _Naslov;
        public bool _Dostupno;
        public string _Osoba;

        public Knjiga(string naslov)
        {
            _Naslov = naslov;
            _Dostupno = true;
            _Osoba = "";
        }

        public string DohvatiOpis()
        {
            return $"Naslov: {_Naslov}, Dostupno: {_Dostupno}, Osoba: {_Osoba}";
        }
    }
}
