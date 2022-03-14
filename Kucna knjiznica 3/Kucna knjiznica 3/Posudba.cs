using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kucna_knjiznica_3
{
    internal class Posudba
    {
        public string _Osoba;
        public Knjiga _PosudjenaKnjiga;
        public DateTime datum;
        public Posudba(string osoba, Knjiga knjiga)
        {
            _Osoba = osoba;
            _PosudjenaKnjiga = knjiga;
            datum = DateTime.Now;
        }
    }
}
