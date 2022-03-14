using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kucna_knjiznica_2
{
    internal class Knjiznica
    {
        public List<Knjiga> popisKnjiga = new List<Knjiga>();

        public Knjiznica()
        {
            popisKnjiga.Add(new Knjiga("Snjeguljica"));
            popisKnjiga.Add(new Knjiga("Trnoruzica"));
            popisKnjiga.Add(new Knjiga("Crvenkapica"));
        }

        public void Posudi(string naslov, string osoba)
        {
            foreach (Knjiga knjiga in popisKnjiga)
            {
                if(naslov == knjiga._Naslov && knjiga._Dostupno == true)
                {
                    knjiga._Dostupno = false;
                    knjiga._Osoba = osoba;
                }
            }
        }
    }
}
