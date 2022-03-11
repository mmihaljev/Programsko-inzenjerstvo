using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konverzija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite iznos koji želite promijeniti u kunama(u tekstualnom obliku znamenku po znamenku): ");
            string[] broj = Console.ReadLine().Split(' ');

            string[] brojevi = new string[] 
            {
                "nula", "jedan", "dva", "tri",
                "cetiri", "pet", "sest",
                "sedam", "osam", "devet"
            };

            string[] iznos = new string[broj.Length];
            int n = 0;

            foreach (string br in broj)
            {
                for (int i = 0; i < brojevi.Length; i++)
                {
                    if(br == brojevi[i])
                    {
                        iznos[n++] = i.ToString();
                    }
                }
            }

            string kune = string.Join("", iznos);
            int uKunama = int.Parse(kune);

            Console.WriteLine("Unesite tečaj eura: ");
            float tecaj = float.Parse(Console.ReadLine());

            float uEurima = uKunama / tecaj;

            Console.WriteLine($"{uKunama} KN po tecaju {tecaj} iznosi {uEurima} EUR!");

            Console.ReadLine();
        }
    }
}
