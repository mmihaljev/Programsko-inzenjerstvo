using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Popis_i_posudba_knjiga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <string> dostupne = new List<string>() { "Prstenova druzina", "Dvije kule", "Rat i mir", "Jadnici" };
            List<string> nedostupne = new List<string>() { "Povratak kralja", "Zlocin i kazna" };

            string[] izbor;

            do
            {
                Console.WriteLine("Unesite naredbu: ");
                izbor = Console.ReadLine().Split(' ');

                switch (izbor[0])
                {
                    case "#popis":
                        foreach (string knjiga in dostupne)
                        {
                            Console.WriteLine($"Naziv: {knjiga}, Status:(dostupna)");
                        };
                        foreach (string knjiga in nedostupne)
                        {
                            Console.WriteLine($"Naziv: {knjiga}, Status:(nedostupna)");
                        };
                        break;
                    case "#posudi":
                        dostupne.Remove(izbor[1]);
                        nedostupne.Add(izbor[1]);
                        Console.WriteLine($"Knjiga {izbor[1]} uspješno posudjena!");
                        break;
                    default:
                        break;
                }

            } while (izbor[0] != "#exit");
        }
    }
}
