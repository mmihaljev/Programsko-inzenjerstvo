using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kucna_knjiznica_1
{
    internal class Knjiznica
    {
        private List<Knjiga> popisKnjiga = new List<Knjiga>();

        public Knjiznica()
        {
            popisKnjiga.Add(new Knjiga("1111", "Snjeguljica", Knjiga._status.Dostupno));
            popisKnjiga.Add(new Knjiga("2222", "Trnoruzica", Knjiga._status.Dostupno));
            popisKnjiga.Add(new Knjiga("3333", "Pepeljuga", Knjiga._status.Dostupno));
        }

        public Knjiga DohvatiKnjigu(string isbn)
        {
            foreach (Knjiga knjiga in popisKnjiga)
            {
                if(isbn == knjiga._ISBN)
                {
                    return knjiga;
                }
            }
            return null;
        }

        public void Posudi(string isbn)
        {
            foreach (Knjiga knjiga in popisKnjiga)
            {
                if(isbn == knjiga._ISBN && knjiga._Status == Knjiga._status.Dostupno)
                {
                    knjiga._Status = Knjiga._status.NaPosudbi;
                }
            }
        }
    }
}
