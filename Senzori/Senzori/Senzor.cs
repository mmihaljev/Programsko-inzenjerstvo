using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senzori
{
    class Senzor
    {
        public string Oznaka;
        public double Vrijednost;
        public enum Jedinica
        {
            Celzius,
            Kelvin
        }
        public Jedinica jedinica;
        public Senzor(string Oznaka,double Vrijednost,Jedinica jedinica)
        {
            this.Oznaka = Oznaka;
            this.Vrijednost = Vrijednost;
            this.jedinica = jedinica;
        }
    }
}
