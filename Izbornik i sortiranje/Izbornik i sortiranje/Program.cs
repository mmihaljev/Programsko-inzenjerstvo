using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbornik_i_sortiranje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int izbor = 0;

            List<string> gradovi = new List<string>();

            while(izbor != 4)
            {
                Console.WriteLine("Odaberite: \n1. Unos podataka \n2. Sortiranje \n3. Ispis \n4. Izlaz");
                izbor = int.Parse(Console.ReadLine());
                switch (izbor)
                {
                    case 1:
                        Console.WriteLine("Unesite gradove (stavite razmak između imena gradova): ");
                        string[] grad = Console.ReadLine().Split(' ');
                        for(int i = 0; i < grad.Length; i++)
                        {
                            gradovi.Add(grad[i]);
                        }
                        break;
                    case 2:
                        Console.WriteLine("1. Silazno\n2. Uzlazno");
                        int izborSort = int.Parse(Console.ReadLine());
                        gradovi.Sort();
                        if (izborSort == 2)
                        {
                            gradovi.Reverse();
                        }
                        break;
                    case 3:
                        Console.WriteLine($"Gradovi su: {string.Join(",", gradovi)}");
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Pogresan unos!");
                        break;
                }
            }
        }
    }
}
