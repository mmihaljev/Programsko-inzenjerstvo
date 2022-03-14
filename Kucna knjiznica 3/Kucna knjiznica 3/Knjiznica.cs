using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kucna_knjiznica_3
{
    internal class Knjiznica
    {
        public List<Knjiga> Knjige = new List<Knjiga>();
        public List<Posudba> Posudbe = new List<Posudba>();

        public Knjiznica()
        {
            Knjige.Add(new Knjiga("1111", "Snjeguljica"));
            Knjige.Add(new Knjiga("2222", "Trnoruzica"));
            Knjige.Add(new Knjiga("3333", "Crvenkapica"));
        }

        public Posudba PosudiKnjigu(string osoba, string isbn)
        {
            foreach (Knjiga knjiga in Knjige)
            {
                if(isbn == knjiga._ISBN)
                {
                    Posudba posudba = new Posudba(osoba, knjiga);
                    Posudbe.Add(posudba);
                    return posudba;
                }
            }
            return null;
        }
    }
}
