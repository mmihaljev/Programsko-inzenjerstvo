using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Godisnje_doba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upišite datum u formatu 'dd mmmm' (npr. 20 siječanj): ");
            string datum = Console.ReadLine();

            int dan = int.Parse(datum.Split(' ')[0]);
            string mjesec = datum.Split(' ')[1];

            switch (mjesec)
            {
                case "sijecanj":
                    Console.WriteLine($"Dan {dan}. {mjesec} pripada godišnjem dobu zima.");
                    break;
                case "veljaca":
                    Console.WriteLine($"Dan {dan}. {mjesec} pripada godišnjem dobu zima.");
                    break;
                case "ozujak":
                    if(dan <= 20)
                    {
                        Console.WriteLine($"Dan {dan}. {mjesec} pripada godišnjem dobu zima.");
                    }
                    else
                    {
                        Console.WriteLine($"Dan {dan}. {mjesec} pripada godišnjem dobu proljeće.");
                    }
                    break;
                case "travanj":
                    Console.WriteLine($"Dan {dan}. {mjesec} pripada godišnjem dobu proljeće.");
                    break;
                case "svibanj":
                    Console.WriteLine($"Dan {dan}. {mjesec} pripada godišnjem dobu proljeće.");
                    break;
                case "lipanj":
                    if (dan <= 20)
                    {
                        Console.WriteLine($"Dan {dan}. {mjesec} pripada godišnjem dobu proljeće.");
                    }
                    else
                    {
                        Console.WriteLine($"Dan {dan}. {mjesec} pripada godišnjem dobu ljeto.");
                    }
                    break;
                case "srpanj":
                    Console.WriteLine($"Dan {dan}. {mjesec} pripada godišnjem dobu ljeto.");
                    break;
                case "kolovoz":
                    Console.WriteLine($"Dan {dan}. {mjesec} pripada godišnjem dobu ljeto.");
                    break;
                case "rujan":
                    if (dan <= 22)
                    {
                        Console.WriteLine($"Dan {dan}. {mjesec} pripada godišnjem dobu ljeto.");
                    }
                    else
                    {
                        Console.WriteLine($"Dan {dan}. {mjesec} pripada godišnjem dobu jesen.");
                    }
                    break;
                case "listopad":
                    Console.WriteLine($"Dan {dan}. {mjesec} pripada godišnjem dobu jesen.");
                    break;
                case "studeni":
                    Console.WriteLine($"Dan {dan}. {mjesec} pripada godišnjem dobu jesen.");
                    break;
                case "prosinac":
                    if (dan <= 20)
                    {
                        Console.WriteLine($"Dan {dan}. {mjesec} pripada godišnjem dobu jesen.");
                    }
                    else
                    {
                        Console.WriteLine($"Dan {dan}. {mjesec} pripada godišnjem dobu zima.");
                    }
                    break;
                default:
                    Console.WriteLine("Krivo unesen datum");
                    break;
            }

            Console.ReadLine();
        }
    }
}
