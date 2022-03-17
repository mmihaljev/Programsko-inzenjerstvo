using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zalihe
{
    class Proizvod
    {
        public string naziv;
        public int cijena;
        public int stanje;
        public Proizvod(string naziv, int cijena, int stanje)
        {
            this.naziv = naziv;
            this.cijena = cijena;
            this.stanje = stanje;
        }
        public double IzracunajVrijednostZaliha(Proizvod x)
        {
            return x.stanje * x.cijena;
        }
        public void DodajNaStanje(int kolicina)
        {
            if (kolicina > 0) this.stanje += kolicina;
        }
        public void OduzmiOdStanja(int kolicina)
        {
            if (kolicina > 0 && this.stanje > kolicina) this.stanje -= kolicina;
        }
    }
}
