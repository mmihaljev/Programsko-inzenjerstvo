using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kucna_knjiznica_1
{
    internal class Knjiga
    {
        public string _ISBN, _Naslov;
        public enum _status
        {
            Dostupno, NaPosudbi
        }
        public _status _Status;

        public Knjiga(string isbn, string naslov, _status status)
        {
            _ISBN = isbn;
            _Naslov = naslov;
            _Status = status;
        }
    }
}
