using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica
{
    internal class KonverterValuta
    {
        TecajnaLista lista = new TecajnaLista();
        public double Konvertiraj(string oznaka, double iznos)
        {
            double konacanIznos = 0;
            foreach (Tecaj tecaj in lista.tecajevi)
            {
                if(tecaj._Oznaka == oznaka)
                {
                    konacanIznos = iznos/tecaj._Tecaj;
                    break;
                }
            }
            return konacanIznos;
        }
        public double VratiTecaj(string oznaka)
        {
            foreach (Tecaj tecaj in lista.tecajevi)
            {
                if (tecaj._Oznaka == oznaka)
                {
                    return tecaj._Tecaj;
                }
            }
            return 0;
        }
    }
}
