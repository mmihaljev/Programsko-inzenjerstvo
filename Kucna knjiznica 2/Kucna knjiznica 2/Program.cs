using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kucna_knjiznica_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite naslobv knjige koju posudujete: ");
            string naslov = Console.ReadLine();
            Console.WriteLine("Unesite ime osobe kojoj posudujete: ");
            string osoba = Console.ReadLine();

            Knjiznica knjiznica = new Knjiznica();

            knjiznica.Posudi(naslov, osoba);
            foreach (Knjiga knjiga in knjiznica.popisKnjiga)
            {
                Console.WriteLine(knjiga.DohvatiOpis());
            }

            Console.ReadLine();
        }
    }
}
