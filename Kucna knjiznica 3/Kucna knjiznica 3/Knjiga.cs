using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kucna_knjiznica_3
{
    internal class Knjiga
    {
        public string _ISBN, _Naslov;
        public Knjiga(string isbn, string naslov)
        {
            _ISBN = isbn;
            _Naslov = naslov;
        }
    }
}
