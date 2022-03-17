using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registracija
{
    class Registrator
    {
        public List<Clan> listaClanova = new List<Clan>();
        public Registrator(List<Clan> listaClanova)
        {
            this.listaClanova.Add(new Clan("pero@foi.hr", "123456"));
            this.listaClanova.Add(new Clan("ivo@foi.hr", "234567"));
            this.listaClanova.Add(new Clan("ante@foi.hr", "345678"));
        }
        private bool EmailZauzet(string emailAdresa)
        {
            foreach(Clan i in listaClanova)
            {
                if (i.EmailAdresa == emailAdresa)
                {
                    
                    return true;
                }
            }
            return false;
        }
        public void RegistirajClana(string email,string lozinka)
        {
            Clan x = new Clan(email, lozinka);
            Validator y = new Validator();
            if (y.ValidirajEmail(email) != true) Console.WriteLine("Email adresa je neispravnog oblika!");
            else
            {
                if (y.ValidirajLozinku(lozinka) != true) Console.WriteLine("Lozinka mora imati između 6 i 10 znakova");
                else
                {
                    if (EmailZauzet(email)) Console.WriteLine("Već postoji član sa navedenim emailom!");
                    else
                    {
                        listaClanova.Add(x);
                        Console.WriteLine("Član je uspješno registriran!");
                    }
                }
            }
        }
    }
}
