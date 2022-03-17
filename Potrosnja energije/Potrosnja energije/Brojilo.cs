using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potrosnja_energije
{
    class Brojilo
    {
        public string Naziv;
        public enum tip
        {
            Voda,
            Struja,
            Plin
        }
        public tip Tip;
        private double stanje;
        private double zadnjeOcitano;
        public Brojilo(string Naziv,tip Tip,double stanje,double zadnjeOcitano)
        {
            this.Naziv = Naziv;
            this.Tip = Tip;
            this.stanje = stanje;
            this.zadnjeOcitano = zadnjeOcitano;
        }
        public double OcitajPotrosnju()
        {
            return stanje - zadnjeOcitano;
        }
    }
}
