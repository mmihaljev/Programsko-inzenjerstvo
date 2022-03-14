using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kucna_knjiznica_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite ISBN knjige koju posudjujete: ");
            string isbn = Console.ReadLine();

            Knjiznica knjiznica = new Knjiznica();

            knjiznica.Posudi(isbn);
            Knjiga knjiga = knjiznica.DohvatiKnjigu(isbn);
            Console.WriteLine($"ISBN: {knjiga._ISBN}\nNaslov: {knjiga._Naslov}\nStatus: {knjiga._Status}");

            Console.ReadLine();
        }
    }
}
