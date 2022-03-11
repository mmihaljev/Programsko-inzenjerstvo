using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite godinu rodjenja: ");
            int godinaRodjenja = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite mjesec rodjenja: ");
            int mjesecRodjenja = int.Parse(Console.ReadLine());

            int trenutnaGodina = DateTime.Now.Year;
            int trenutniMjesec = DateTime.Now.Month;

            int brojMjeseci = (12-mjesecRodjenja)+(trenutnaGodina-(godinaRodjenja+1))*12+(trenutniMjesec-1);
            int brojDana = brojMjeseci * 30;

            Console.WriteLine($"{brojMjeseci} mjeseci\n{brojDana} dana");

            Console.ReadLine();
        }
    }
}
