using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glasanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("APLIKACIJA ZA GLASOVANJE\n-----------------------------");
            GlasackaKutija kutija = new GlasackaKutija();
            while (true)
            {
                Console.WriteLine("Unesite OIB:");
                string oib = Console.ReadLine();
                Console.WriteLine("Unesite odabir [Z] = Za, [P] = Protiv i [S] = Suzdržan:");
                string unos = Console.ReadLine();

                kutija.Glasaj(oib, unos);
                kutija.DohvatiRezultateGlasanja();
            }
        }
    }
}
