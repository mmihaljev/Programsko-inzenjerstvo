using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novcana_naknada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] zaposlenici = new string[]
            {
                "Ivan Ivic;8NS",
                "Ivan Ivic;6DS",
                "Ivan Ivic;4DS",
                "Ivan Ivic;4P",
                "Pero Peric;3NS",
                "Pero Peric;5DS",
                "Pero Peric;7DS",
                "Pero Peric;4DS",
                "Pero Peric;3P"
            };

            Console.WriteLine("Unesite ime zaposlenika: ");
            string zaposlenik = Console.ReadLine();

            float placa = 0;

            foreach (string zaposleni in zaposlenici)
            {
                string[] imeSati = zaposleni.Split(';');
                if(imeSati[0] == zaposlenik)
                {
                    int brojSati = int.Parse(imeSati[1].Substring(0,1));
                    string tip = imeSati[1].Substring(1, 1);
                    switch (tip)
                    {
                        case "D":
                            placa += brojSati * 150;
                            break;
                        case "N":
                            placa += brojSati * 1.5f * 150;
                            break;
                        case "P":
                            placa += brojSati * 2 * 150;
                            break;
                        default:
                            break;
                    }
                }
            }

            Console.WriteLine($"Zaposleniku {zaposlenik} trebate isplatiti {placa} KN.");

            Console.ReadLine();
        }
    }
}
