using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite iznos u HRK koji zelite promijeniti: ");
            double iznos = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite valutu u koju zelite promijeniti: ");
            string oznaka = Console.ReadLine();

            Mjenjacnica mjenjacnica = new Mjenjacnica();
            Potvrda potvrda = mjenjacnica.PromijeniNovac(iznos, oznaka);
            mjenjacnica.IspisPotvrde(potvrda);

            Console.ReadLine();
        }
    }
}
