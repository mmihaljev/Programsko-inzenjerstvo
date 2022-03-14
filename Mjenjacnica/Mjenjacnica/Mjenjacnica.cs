using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica
{
    internal class Mjenjacnica
    {
        public Potvrda PromijeniNovac(double iznos, string oznaka)
        {
            KonverterValuta konveter = new KonverterValuta();
            double konvertirano = konveter.Konvertiraj(oznaka, iznos);
            double naknada = konvertirano*0.05;
            double zaIsplatiti = konvertirano - naknada;

            Potvrda potvrda = new Potvrda(DateTime.Now, iznos, konveter.VratiTecaj(oznaka), konvertirano, naknada, oznaka, zaIsplatiti);

            return potvrda;
        }

        public void IspisPotvrde(Potvrda potvrda)
        {
            Console.WriteLine($"Datum: {potvrda._Datum}\nIznos za promjenu: {potvrda._Iznos} HRK\nPo tecaju: {potvrda._Tecaj}\nIznosi: {potvrda._KonvertIznos} {potvrda._Oznaka}" +
                $"\nNaknada: 5% ({potvrda._Naknada} {potvrda._Oznaka})\n-----------------------\nZa isplatiti: {potvrda._ZaIsplatiti} {potvrda._Oznaka}");
        }
    }
}
