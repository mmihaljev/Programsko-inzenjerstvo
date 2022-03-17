using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potrosnja_energije
{
    class Kuca
    {
        public List<Brojilo> _Brojilo = new List<Brojilo>();
        public Kuca(List<Brojilo> _Brojilo)
        {
            this._Brojilo.Add(new Brojilo("HEP_101", Brojilo.tip.Struja, 34235, 32150));
            this._Brojilo.Add(new Brojilo("TP_222", Brojilo.tip.Plin, 11500, 10400));
            this._Brojilo.Add(new Brojilo("VAR_123", Brojilo.tip.Voda, 16225, 16100));
        }
        private double DohvatiCijenuEnergenata(Brojilo.tip x)
        {
            if (x == Brojilo.tip.Voda) return 3.5;
            else if (x == Brojilo.tip.Struja) return 0.1;
            else return 0.2;
        }
        public double IzracunajIznosZaBrojilo(Brojilo x)
        {
            return x.OcitajPotrosnju() * DohvatiCijenuEnergenata(x.Tip);
        }
        public double IzracunajIznosUkupno()
        {
            double zbroj = 0;
            foreach(Brojilo i in _Brojilo)
            {
                zbroj+=IzracunajIznosZaBrojilo(i);
            }
            return zbroj;
        }
    }
}
