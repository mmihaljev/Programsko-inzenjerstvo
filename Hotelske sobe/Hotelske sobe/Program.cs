using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelske_sobe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Hotel hotel = new Hotel();

            string odabir = "";
            do
            {
                Console.WriteLine("Unesite naredbu: ");
                odabir = Console.ReadLine();

                switch (odabir.Split(' ')[0])
                {
                    case "#pronadji":
                        List<Soba> sobe = new List<Soba>();
                        sobe = hotel.PronadjiSobe(int.Parse(odabir.Split(' ')[1]));
                        foreach (Soba soba in sobe)
                        {
                            Console.WriteLine($"Oznaka: {soba._Oznaka}, Kapacitet: {soba._Kapacitet}, Status: {soba._Status}");
                        }
                        break;
                    case "#rezerviraj":
                        hotel.RezervirajSobu(odabir.Split(' ')[1]);
                        break;
                    default:
                        break;
                }

            } while (odabir != "#exit");
        }
    }
}
