using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prijava
{
    class Autentifikator
    {
        List<Korisnik> listaKorisnika = new List<Korisnik>();
        public Autentifikator()
        {
            this.listaKorisnika.Add(new Korisnik("pperic", "1111"));
            this.listaKorisnika.Add(new Korisnik("iivic", "1234"));
            this.listaKorisnika.Add(new Korisnik("aantic", "9876"));
        }
        private Korisnik DohvatiKorisnika(string korisnickoIme)
        {
            foreach(Korisnik i in listaKorisnika)
            {
                if (i.KorisnickoIme == korisnickoIme) return i;
            }
            return null;
        }
        public void PrijaviKorisnika(string korisnickoIme,string lozinka)
        {
            Korisnik x = DohvatiKorisnika(korisnickoIme);
            if (x != null)
            {
                if (x.Lozinka == lozinka) Console.WriteLine("Uspješno prijavljen korisnik!");
                else Console.WriteLine("Pogrešno upisana lozinka!");
            }
            else Console.WriteLine("Ne postoji korisnik sa navedenim korisničkim imenom!");
        }
    }
}
