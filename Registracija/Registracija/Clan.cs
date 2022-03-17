using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registracija
{
    class Clan
    {
        public string EmailAdresa;
        public string Lozinka;
        public Clan(string EmailAdresa,string Lozinka)
        {
            this.EmailAdresa = EmailAdresa;
            this.Lozinka = Lozinka;
        }
    }
}
