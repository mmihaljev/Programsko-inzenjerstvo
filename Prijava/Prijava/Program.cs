using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prijava
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Korisničko ime: ");
            string ime = Console.ReadLine();
            Console.WriteLine("Lozinka: ");
            string lozinka = Console.ReadLine();
            Autentifikator x = new Autentifikator();
            x.PrijaviKorisnika(ime, lozinka);
            Console.Read();
        }
    }
}
