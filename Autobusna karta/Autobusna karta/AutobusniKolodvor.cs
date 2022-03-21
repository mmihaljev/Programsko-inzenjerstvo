using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autobusna_karta
{
    internal class AutobusniKolodvor
    {
        private List<Linija> _linije = new List<Linija>();

        public AutobusniKolodvor()
        {
            _linije.Add(new Linija("Varazdin", "Zagreb", 80));
            _linije.Add(new Linija("Varazdin", "Cakovec", 20));
            _linije.Add(new Linija("Varazdin", "Slavonski Brod", 240));
            _linije.Add(new Linija("Varazdin", "Krapina", 40));
            _linije.Add(new Linija("Varazdin", "Novi Marof", 22));
            _linije.Add(new Linija("Varazdin", "Koprivnica", 45));
            _linije.Add(new Linija("Varazdin", "Virovitica", 100));
            _linije.Add(new Linija("Varazdin", "Osijek", 220));
        }

        private double IzracunajCijenu(int udaljenost, string tipKarte)
        {
            double cijena = 0;
            switch (tipKarte)
            {
                case "Regularna":
                    cijena = udaljenost * 1.5;
                    break;
                case "Studentska":
                    cijena = udaljenost * 1.2;
                    break;
                case "Povratna":
                    cijena = udaljenost * 2;
                    break;
                default:
                    break;
            }

            return cijena;
        }

        public string KupiKartu(string polaziste, string odrediste, string tipKarte)
        {
            double cijena = 0;

            foreach (Linija linija in _linije)
            {
                if(polaziste == linija._Polaziste && odrediste == linija._Odrediste)
                {
                    cijena = IzracunajCijenu(linija._Udaljenost, tipKarte);
                    break;
                }
            }

            return $"Cijena za kartu tipa {tipKarte}, na relaciji {polaziste} - {odrediste} iznosi {cijena} kn!";
        }
    }
}
