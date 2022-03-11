using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonetska_abeceda_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite riječ koristeći fonetsku abecedu: ");
            string rijec = Console.ReadLine();

            string[] rijeci = rijec.Split(' ');

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
            string slovo;

            foreach (string dio in rijeci)
            {
                for(int i = 0; i < abeceda.Length; i++)
                {
                    if(dio == abeceda[i])
                    {
                        slovo = dio.Substring(0,1);
                        rjesenje.Add(slovo);
                    }
                }
            }

            if (rjesenje.Count != rijeci.Length)
            {
                Console.WriteLine("Pogrešan unos!");
            }
            else
            {
                Console.WriteLine($"Vaša riječ je {string.Join("", rjesenje)}");
            }
            
            Console.ReadLine();
        }
    }
}
