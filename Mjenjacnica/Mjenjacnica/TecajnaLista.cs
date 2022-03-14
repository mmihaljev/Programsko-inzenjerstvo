using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica
{
    internal class TecajnaLista
    {
        public List<Tecaj> tecajevi = new List<Tecaj>();

        public TecajnaLista()
        {
            tecajevi.Add(new Tecaj("EUR", 7.5));
            tecajevi.Add(new Tecaj("USD", 6));
            tecajevi.Add(new Tecaj("AUD", 5));
        }
    }
}
