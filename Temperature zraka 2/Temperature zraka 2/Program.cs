using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_zraka_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string meteoStanica = "13,2;C|286,85;K|-|14,8;C|15,1;C|287,95;K|14,2;C|13,7;C";

            string[] rezultati = meteoStanica.Split('|');

            for (int i = 0; i < rezultati.Length; i++)
            {
                if (rezultati[i] == "-")
                {
                    Console.WriteLine($"{i}. ocitovanje = Nije uspjelo!");
                }
                else
                {
                    if (rezultati[i].Split(';')[1] == "C")
                    {
                        Console.WriteLine($"{i}. ocitovanje = {rezultati[i].Split(';')[0]}C");
                    }
                    else if (rezultati[i].Split(';')[1] == "K")
                    {
                        float temperatura = float.Parse(rezultati[i].Split(';')[0])-273.15f;
                        Console.WriteLine($"{i}. ocitovanje = {temperatura.ToString("0.00")} C");
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
