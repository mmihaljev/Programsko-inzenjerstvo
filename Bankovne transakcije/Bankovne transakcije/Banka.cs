using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankovne_transakcije
{
    internal class Banka
    {
        private List<Racun> _banke = new List<Racun>();

        public Banka()
        {
            _banke.Add(new Racun("HR11", 100000));
            _banke.Add(new Racun("HR22", 50000));
            _banke.Add(new Racun("HR33", 12000));
            _banke.Add(new Racun("HR44", 36000));
        }

        private Racun DohvatiRacun(string iban)
        {
            foreach (Racun racun in _banke)
            {
                if(iban == racun._IBAN)
                {
                    return racun;
                }
            }

            return null;
        }

        public Transakcija IzvrsiPlacanje(string ibanPlatitelja, string ibanPrimatelja, double iznos)
        {
            Transakcija transakcija = new Transakcija();
            Racun platitelj = DohvatiRacun(ibanPlatitelja);
            Racun primatelj = DohvatiRacun(ibanPrimatelja);
            transakcija.iznos = iznos;
            transakcija._Platitelj= platitelj;
            transakcija._Primatelj= primatelj;

            return transakcija;
        }
    }
}
