using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starost_osobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> mjeseci = new List<string>()
            {
                "sijecanj", "veljaca", "ozujak",
                "travanj", "svibanj", "lipanj",
                "srpanj", "kolovoz", "rujan",
                "listopad", "studeni", "prosinac"
            };

            Console.WriteLine("Upisite datum rodjenja u formatu 'dd mmmm yyyy' (npr. 20. sijecanj 1995): ");
            string datumRodjenja = Console.ReadLine();
            int danRodjenja = int.Parse(datumRodjenja.Split(' ')[0]);
            int godinaRodjenja = int.Parse(datumRodjenja.Split(' ')[2]);
            int mjesecRodjenja = 0;

            for (int i = 0; i < mjeseci.Count; i++)
            {
                if(mjeseci[i] == datumRodjenja.Split(' ')[1])
                {
                    mjesecRodjenja = i + 1;
                    break;
                }
            }

            int trenutniDan = DateTime.Now.Day;
            int trenutnaGodina = DateTime.Now.Year;
            int trenutniMjesec = DateTime.Now.Month;

            Console.WriteLine(trenutniDan);
            Console.WriteLine(trenutniMjesec);
            Console.WriteLine(trenutnaGodina);

            int brojGodina = trenutnaGodina - godinaRodjenja;

            if (mjesecRodjenja < trenutniMjesec)
            {
                Console.WriteLine($"Dana {danRodjenja}.{mjesecRodjenja}.{trenutnaGodina}. godine napunili ste {brojGodina} godina!");
            }
            else if (mjesecRodjenja > trenutniMjesec)
            {
                Console.WriteLine($"Dana {danRodjenja}.{mjesecRodjenja}.{trenutnaGodina}. godine napunit ćete {brojGodina} godina!");
            }
            else
            {
                if (danRodjenja < trenutniDan)
                {
                    Console.WriteLine($"Dana {danRodjenja}.{mjesecRodjenja}.{trenutnaGodina}. godine napunili ste {brojGodina} godina!");
                }
                else if (danRodjenja > trenutniDan)
                {
                    Console.WriteLine($"Dana {danRodjenja}.{mjesecRodjenja}.{trenutnaGodina}. godine napunit ćete {brojGodina} godina!");
                }
                else
                {
                    Console.WriteLine("Sretan rođendan!");
                }
            }


            Console.ReadLine(); 
        }
    }
}
