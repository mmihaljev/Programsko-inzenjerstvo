using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankovne_transakcije
{
    internal class Racun
    {
        public string _IBAN;
        public double _Stanje;

        public Racun(string iban, double stanje)
        {   
            _IBAN = iban;
            _Stanje = stanje;
        }
    }
}
