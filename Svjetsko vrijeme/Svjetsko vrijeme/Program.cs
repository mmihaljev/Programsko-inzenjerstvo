using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svjetsko_vrijeme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> gradovi = new List<string>()
            {
                "Santiago;-4",
                "Salvador;-3",
                "London;+0",
                "Zagreb;+1",
                "Damask;+2",
                "Istanbul;+3"
            };

            foreach (string grad in gradovi)
            {
                string predznak = grad.Split(';')[1].Substring(0, 1);
                int sati = int.Parse(grad.Split(';')[1].Substring(1, 1));
                if (predznak == "-")
                {
                    Console.WriteLine($"Trenutno vrijeme za {grad.Split(';')[0]} je: {DateTime.UtcNow.AddHours(-sati).ToShortTimeString()}");
                } else if (predznak == "+")
                {
                    Console.WriteLine($"Trenutno vrijeme za {grad.Split(';')[0]} je: {DateTime.UtcNow.AddHours(sati).ToShortTimeString()}");
                }
            }

            Console.ReadLine();
        }
    }
}
