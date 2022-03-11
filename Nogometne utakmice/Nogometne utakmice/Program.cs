using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogometne_utakmice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tekme = new string[]
            {
                "HRV 2:0 NIG",
                "HRV 3:0 ARG",
                "HRV 2:1 ISL",
                "HRV 1:1 DAN",
                "HRV 2:2 RUS",
                "HRV 2:1 ENG",
                "HRV 2:4 FRA"
            };

            int pobjeda = 0;
            int poraz = 0;
            int remi = 0;

            foreach (string tekma in tekme)
            {   
                string[] rezultat = tekma.Split(' ');
                string[] golovi = rezultat[1].Split(':');

                if(int.Parse(golovi[0]) > int.Parse(golovi[1]))
                {
                    pobjeda++;
                }
                else if(int.Parse(golovi[0]) < int.Parse(golovi[1]))
                {
                    poraz++;
                }
                else
                {
                    remi++;
                };
            }

            Console.WriteLine($"Ukupno pobjeda: {pobjeda}\nUkupno poraza: {poraz}\nUkupno nerješenih: {remi}");

            Console.ReadLine();
        }
    }
}
