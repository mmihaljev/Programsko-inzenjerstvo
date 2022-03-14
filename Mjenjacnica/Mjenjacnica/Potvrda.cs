using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica
{
    internal class Potvrda
    {
        public DateTime _Datum;
        public double _Iznos;
        public double _Tecaj, _KonvertIznos, _Naknada, _ZaIsplatiti;
        public string _Oznaka;

        public Potvrda(DateTime datum, double iznos, double tecaj, double konvertIznos, double naknada, string oznaka, double zaIsplatiti)
        {
            _Datum = datum;
            _Iznos = iznos;
            _Tecaj = tecaj;
            _KonvertIznos = konvertIznos;
            _Naknada = naknada;
            _ZaIsplatiti = zaIsplatiti;
            _Oznaka = oznaka;
        }
    }
}
