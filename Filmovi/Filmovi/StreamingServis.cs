using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmovi
{
    class StreamingServis
    {
        public List<Film> filmovi = new List<Film>();
        public StreamingServis()
        {
            filmovi.Add(new Film("Film 1", Film.Zanr.Komedija, 88, false));
            filmovi.Add(new Film("Film 2", Film.Zanr.Akcija, 95, false));
            filmovi.Add(new Film("Film 3", Film.Zanr.Horor, 70, true));
            filmovi.Add(new Film("Film 4", Film.Zanr.Komedija, 120, false));
            filmovi.Add(new Film("Film 5", Film.Zanr.Akcija, 110, true));
            filmovi.Add(new Film("Film 6", Film.Zanr.Horor, 99, false));
            filmovi.Add(new Film("Film 7", Film.Zanr.Komedija, 75, false));
            filmovi.Add(new Film("Film 8", Film.Zanr.Akcija, 80, false));
            filmovi.Add(new Film("Film 9", Film.Zanr.Horor, 81, false));
            filmovi.Add(new Film("Film 10", Film.Zanr.Komedija, 99, true));
        }
        private List<Film> DohvatiFilmoveKojeNisamGledao()
        {
            List<Film> novo = new List<Film>();
            foreach(Film i in filmovi)
            {
                if (!i.VecGledan) novo.Add(i);
            }
            return novo;
        }
        public void PredloziFilm()
        {
            List<Film> novo = DohvatiFilmoveKojeNisamGledao();
            Random rnd = new Random();
            int random = rnd.Next(1,novo.Count);
            Film x=new Film("Test",Film.Zanr.Akcija,90,false);
            string y = x.DohvatiInfo(novo[random]);
            Console.WriteLine(y);
        }
    }
}
