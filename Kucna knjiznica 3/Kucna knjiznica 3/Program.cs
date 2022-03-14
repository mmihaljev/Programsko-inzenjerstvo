using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kucna_knjiznica_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite ime i prezime osobe kojoj posudujemo knjigu: ");
            string ime = Console.ReadLine();
            Console.WriteLine("Unesite ISBN knjige: ");
            string isbn = Console.ReadLine();

            Knjiznica knjiznica = new Knjiznica();

            Posudba posudba = knjiznica.PosudiKnjigu(ime, isbn);
            Console.WriteLine($"Osoba: {posudba._Osoba}\nISBN knjige: {posudba._PosudjenaKnjiga._ISBN}\nNaslov knjige: {posudba._PosudjenaKnjiga._Naslov}\nDatum posudbe: {posudba.datum}");
            
            Console.ReadLine();
        }
    }
}
