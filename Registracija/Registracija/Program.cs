using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registracija
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Registracija");
            Console.WriteLine("Email:");
            string mail = Console.ReadLine();
            Console.WriteLine("Lozinka:");
            string lozinka = Console.ReadLine();
            List<Clan> clanovi = new List<Clan>();
            Registrator reg = new Registrator(clanovi);
            reg.RegistirajClana(mail, lozinka);
            Console.Read();
        }
    }
}
