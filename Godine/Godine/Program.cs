using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Godine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite godinu rođenja: ");
            int godinaRodjenja = int.Parse(Console.ReadLine());

            int trenutnaGodina = DateTime.Now.Year;

            int starost = trenutnaGodina - godinaRodjenja;

            int brojPrijestupnih = 0;

            for (int i = godinaRodjenja; i < trenutnaGodina; i++)
            {
                if (i%4==0 && (i%400==0 || i%100!=0))
                {
                    brojPrijestupnih++;
                }
            }

            Console.WriteLine($"Imas {starost} godina i preživio si {brojPrijestupnih} prijestupnih godina.");

            Console.ReadLine();
        }
    }
}
