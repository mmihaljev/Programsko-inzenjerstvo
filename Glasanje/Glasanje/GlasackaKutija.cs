using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glasanje
{
    internal class GlasackaKutija
    {
        private List<Glas> glasovi = new List<Glas>();

        private Boolean VecGlasao(string oib)
        {
            foreach (Glas glas in glasovi)
            {
                if(glas._OIB == oib)
                {
                    return true;
                }
            }
            return false;
        }

        public void Glasaj(string oib, string odabir)
        {
            if(VecGlasao(oib) == false)
            {
                Console.WriteLine("Uspjesno ste glasali!");
                glasovi.Add(new Glas(oib, odabir));
            } else Console.WriteLine("Vec ste glasali!");
        }

        public void DohvatiRezultateGlasanja()
        {
            int za = 0, protiv = 0, suzdrzan = 0;
            foreach (Glas glas in glasovi)
            {
                switch (glas._Odabir)
                {
                    case "Z":
                        za += 1;
                        break;
                    case "P":
                        protiv += 1;
                        break;
                    case "S":
                        suzdrzan += 1;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Rezultati glasovanja: ZA = {za}, PROTIV = {protiv}, SUZDRZAN = {suzdrzan}\n-----------------------------------------------------");
        }
    }
}
