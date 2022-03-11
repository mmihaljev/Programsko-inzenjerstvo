using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brojevi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A= ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("B= ");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("C= ");
            int C = int.Parse(Console.ReadLine());

            int suma = 0;
            List<int> djeljivi = new List<int>();

            for (int i = A; i <= B; i++)
            {
                if(i%C == 0)
                {
                    djeljivi.Add(i);
                    suma += i;
                }
            }

            Console.WriteLine($"Rezultat je {string.Join(",", djeljivi)}");
            Console.WriteLine($"Suma je {suma}");
            
            Console.ReadLine();
        }
    }
}
