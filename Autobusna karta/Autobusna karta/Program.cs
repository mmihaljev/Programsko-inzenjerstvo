using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autobusna_karta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite polaziste, odrediste i tip karte: ");
            string unos = Console.ReadLine();

            AutobusniKolodvor kolodvor = new AutobusniKolodvor();

            string ispis = kolodvor.KupiKartu(unos.Split(' ')[0], unos.Split(' ')[1], unos.Split(' ')[2]);
            Console.WriteLine(ispis);

            Console.ReadLine();
        }
    }
}
