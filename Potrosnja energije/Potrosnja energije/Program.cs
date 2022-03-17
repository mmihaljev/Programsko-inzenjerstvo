using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potrosnja_energije
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Brojilo> _Brojilo = new List<Brojilo>();
            Kuca kuca = new Kuca(_Brojilo);
            for(int i=0;i<kuca._Brojilo.Count;i++)
            {
                Console.WriteLine($"Brojilo {kuca._Brojilo[i].Naziv} ({kuca._Brojilo[i].Tip}) = {kuca.IzracunajIznosZaBrojilo(kuca._Brojilo[i])} kn");
            }
            Console.WriteLine("Ukupno: " + kuca.IzracunajIznosUkupno()+" kn");
            Console.Read();
        }
    }
}
