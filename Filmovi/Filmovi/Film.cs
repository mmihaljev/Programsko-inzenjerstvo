using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmovi
{
    class Film
    {
        public string Naziv;
        public enum Zanr
        {
            Komedija,
            Akcija,
            Horor
        }
        Zanr zanr;
        public int Trajanje;
        public bool VecGledan;
        public Film(string Naziv,Zanr zanr,int Trajanje,bool VecGledan)
        {
            this.Naziv = Naziv;
            this.Trajanje = Trajanje;
            this.VecGledan = VecGledan;
            this.zanr = zanr;
        }
        public string DohvatiInfo(Film x)
        {
            
            return $"{x.Naziv} ({x.zanr},{x.Trajanje})";
        }
    }
}
