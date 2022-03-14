using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelske_sobe
{
    internal class Hotel
    {
        private List<Soba> sobe = new List<Soba>();

        public Hotel()
        {
            sobe.Add(new Soba("10A", 3, Soba.StatusSobe.Slobodna));
            sobe.Add(new Soba("10B", 1, Soba.StatusSobe.Rezervirana));
            sobe.Add(new Soba("11A", 2, Soba.StatusSobe.Slobodna));
            sobe.Add(new Soba("11B", 4, Soba.StatusSobe.Slobodna));
            sobe.Add(new Soba("12A", 5, Soba.StatusSobe.Slobodna));
            sobe.Add(new Soba("12B", 3, Soba.StatusSobe.Rezervirana));
            sobe.Add(new Soba("13A", 1, Soba.StatusSobe.Slobodna));
            sobe.Add(new Soba("13B", 2, Soba.StatusSobe.Rezervirana));
        }

        public List<Soba> PronadjiSobe(int brojOsoba)
        {
            List<Soba> slobodneSobe = new List<Soba>();
            foreach (Soba soba in sobe)
            {
                if(soba._Status == Soba.StatusSobe.Slobodna && soba._Kapacitet >= brojOsoba)
                {
                    slobodneSobe.Add(soba);
                }
            }
            return slobodneSobe;
        }

        public void RezervirajSobu(string oznaka)
        {
            foreach (Soba soba in sobe)
            {
                if (oznaka == soba._Oznaka && soba._Status == Soba.StatusSobe.Slobodna)
                {
                    soba._Status = Soba.StatusSobe.Rezervirana;
                    Console.WriteLine("Rezervirana soba!");
                }
            }
        }
    }
}
