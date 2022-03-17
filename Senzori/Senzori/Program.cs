using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senzori
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C ili K?");
            string temp = Console.ReadLine();
            Senzor.Jedinica tempp=new Senzor.Jedinica();
            if (temp == "C") tempp = Senzor.Jedinica.Celzius;
            else if (temp == "K") tempp = Senzor.Jedinica.Kelvin;
            MeteoStanica x = new MeteoStanica();
            Console.WriteLine("Prosjecna: " + x.DohvatiProsjecnuTemperaturu(tempp) + " (" + tempp + ")");
            Console.Read();
        }
    }
}
