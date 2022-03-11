using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonteska_abeceda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite riječ: ");
            string rijec = Console.ReadLine();

            char[] slova = rijec.ToArray();

            string[] abeceda = new string[]
            {
                "Alfa", "Bravo", "Charlie",
                "Delta", "Echo", "Foxtrot",
                "Golf", "Hotel", "India",
                "Juliett", "Kilo", "Lima",
                "Mike", "November", "Oscar",
                "Papa", "Quebec", "Romeo",
                "Sierra", "Tango", "Uniform",
                "Victor", "Whiskey", "Xray",
                "Yankee", "Zulu"
            };

            List<string> rjesenje = new List<string>();

            for (int i = 0; i < slova.Length; i++)
            {
                for (int j = 0; j < abeceda.Length; j++)
                {
                    if(abeceda[j].StartsWith(slova[i].ToString()))
                    {
                        rjesenje.Add(abeceda[j]);
                    }
                }
            }

            
            Console.WriteLine($"Vaša riječ u fonetskoj abecedi je {string.Join(" ", rjesenje)}");

            Console.ReadLine();
        }
    }
}
