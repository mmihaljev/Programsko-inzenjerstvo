using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senzori
{
    class MeteoStanica
    {
        List<Senzor> senzori = new List<Senzor>();
        public MeteoStanica()
        {
            senzori.Add(new Senzor("Senzor 1", 8.4, Senzor.Jedinica.Celzius));
            senzori.Add(new Senzor("Senzor 2", 281.5, Senzor.Jedinica.Kelvin));
            senzori.Add(new Senzor("Senzor 3", 8.9, Senzor.Jedinica.Celzius));
            senzori.Add(new Senzor("Senzor 4", 9.1, Senzor.Jedinica.Celzius));
        }
        private double Pretvori(Senzor.Jedinica izJedinice,Senzor.Jedinica uJedinicu,double vrijednost)
        {
            if (izJedinice == Senzor.Jedinica.Celzius && izJedinice!=uJedinicu ) return vrijednost+273.15;
            else if (izJedinice == Senzor.Jedinica.Kelvin && izJedinice!=uJedinicu) return vrijednost - 273.15;
            return vrijednost;
        }
        public double DohvatiProsjecnuTemperaturu(Senzor.Jedinica jedinica)
        {
            double zbroj = 0, x = 0;
            foreach(Senzor i in senzori)
            {
                if (i.jedinica != jedinica) zbroj += Pretvori(i.jedinica, jedinica, i.Vrijednost);
                else zbroj += i.Vrijednost;
                x++;
            }
            return zbroj / x;
        }
    }
}
