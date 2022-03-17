using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registracija
{
    class Validator
    {
        public bool ValidirajEmail(string emailAdresa)
        {
            if (emailAdresa.Contains("@foi.hr")) return true;
            return false;
        }
        public bool ValidirajLozinku(string Lozinka)
        {
            if (Lozinka.Length >= 6 && Lozinka.Length <= 10) return true;
            return false;
        }
    }
}
