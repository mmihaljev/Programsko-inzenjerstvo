using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potencije
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj X: ");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Unesite broj Y: ");
            int y = int.Parse(Console.ReadLine());

            float rjesenje;

            if (y > 0)
            {
                rjesenje = x;
                for (int i = 0; i < y - 1; i++)
                {
                    rjesenje *= x;
                }
            }
            else if (y < 0)
            {
                float faktor = 1 / x;
                rjesenje = faktor;
                for (int i = 0; i > y + 1; i--)
                {
                    rjesenje *= faktor;
                }
            }
            else rjesenje = 0;

            Console.WriteLine($"Rjesenje je {rjesenje}");

            Console.ReadLine();
        }
    }
}
