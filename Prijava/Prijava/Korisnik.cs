using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prijava
{
    class Korisnik
    {
        public string KorisnickoIme;
        public string Lozinka;
        public Korisnik(string KorisnickoIme,string Lozinka)
        {
            this.KorisnickoIme = KorisnickoIme;
            this.Lozinka = Lozinka;
        }
    }
}
