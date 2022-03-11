using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogometne_utakmice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rezultati = new string[]
            {
                "ARG 1:1 ISL",
                "HRV 2:0 NIG",
                "ARG 0:3 HRV",
                "NIG 2:0 ISL",
                "NIG 1:2 ARG",
                "ISL 1:2 HRV"
            };

            Console.WriteLine("Unesite oznaku reporezentacije: ");
            string oznaka = Console.ReadLine();

            Console.WriteLine($"Utakmice reprezentacije {oznaka}: ");

            foreach (string rezultat in rezultati)
            {
                string[] rez = rezultat.Split(' ');
                for (int i = 0; i < 3; i++)
                {
                    if(oznaka == rez[i])
                    {
                        if(i == 0)
                        {
                            Console.WriteLine(rezultat);
                        }
                        else if(i == 2)
                        {
                            string[] golovi = rez[1].Split(':');
                            Console.WriteLine($"{rez[2]} {golovi[1]}:{golovi[0]} {rez[0]}");
                        }
                    }
                }
            }
            
            Console.ReadLine();
        }
    }
}
