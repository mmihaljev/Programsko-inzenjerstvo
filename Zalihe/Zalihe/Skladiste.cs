using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zalihe
{
    class Skladiste
    {
        List<Proizvod> Proizvodi = new List<Proizvod>();
        public Skladiste(List<Proizvod> Proizvodi)
        {
            this.Proizvodi = Proizvodi;
        }
        public void DodajProizvod(Proizvod x)
        {
            if (Proizvodi.Contains(x) == false) Proizvodi.Add(x);
        }
        public void UkloniProizvod(Proizvod x)
        {
            Proizvodi.Remove(x);
        }
        public Proizvod DohvatiProizvod(string naziv)
        {
            foreach(Proizvod i in Proizvodi)
            {
                if (i.naziv == naziv) return i;
            }
            return null;
        }
        public string DohvatiSveProizvode()
        {
            string i = "";
            foreach (Proizvod x in Proizvodi)
            {
                i+=x.naziv+"\t"+x.stanje+"\t"+x.cijena+"\n";
            }
            return i;
        }
        public double IzracunajUkupnuVrijednostZaliha()
        {
            double zbroj=0;
            foreach(Proizvod i in Proizvodi)
            {
                zbroj+=i.IzracunajVrijednostZaliha(i);
            }
            return zbroj;
        }       
    }
}
