using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankovne_transakcije
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite IBAN platitelja: ");
            string ibanPlatitelj = Console.ReadLine();
            Console.WriteLine("Unesite IBAN primatelja: ");
            string ibanPrimatelj = Console.ReadLine();
            Console.WriteLine("Unesite iznos plaćanja: ");
            int iznos = int.Parse(Console.ReadLine());

            Banka banka = new Banka();

            Transakcija transakcija = banka.IzvrsiPlacanje(ibanPlatitelj, ibanPrimatelj, iznos);

            Console.WriteLine($"POTVRDA TRNSAKCIJE:\n----------------------\nNovo stanje računa {transakcija._Platitelj._IBAN} je {transakcija._Platitelj._Stanje-transakcija.iznos}");
            Console.WriteLine($"Novo stanje računa {transakcija._Primatelj._IBAN} je {transakcija._Primatelj._Stanje + transakcija.iznos}");


            Console.ReadLine();
        }
    }
}
