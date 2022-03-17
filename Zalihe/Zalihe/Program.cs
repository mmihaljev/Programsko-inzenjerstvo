using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zalihe
{
    class Program
    {
        static void Main(string[] args)
        {
            string izbor = "";
            List<Proizvod> x=new List<Proizvod>();
            Skladiste z = new Skladiste(x);
            do
            {
                Console.WriteLine("1.Dodaj,2.Povećaj,3.Smanji,4.Ispisi");
                izbor=Console.ReadLine();
                if (izbor == "1")
                {
                    Console.WriteLine("Koji proizvod zelite dodati? ");
                    string y = Console.ReadLine();
                    Console.WriteLine("Cijena? ");
                    int cijena = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Stanje? ");
                    int stanje = Convert.ToInt32(Console.ReadLine());
                    Proizvod q = new Proizvod(y, cijena, stanje);
                    z.DodajProizvod(q);
                }
                else if (izbor == "2")
                {
                    Console.WriteLine("Na koji proizvod zelite dodati");
                    string q = Console.ReadLine();
                    Console.WriteLine("Koliko proizvoda zelite dodati?");
                    int y = Convert.ToInt32(Console.ReadLine());
                    z.DohvatiProizvod(q).DodajNaStanje(y);
                }
                else if (izbor == "3")
                {
                    Console.WriteLine("Na koji proizvod zelite oduzeti");
                    string q = Console.ReadLine();
                    Console.WriteLine("Koliko proizvoda zelite oduzeti?");
                    int y = Convert.ToInt32(Console.ReadLine());
                    z.DohvatiProizvod(q).OduzmiOdStanja(y);
                }
                else if (izbor == "4")
                {
                    Console.WriteLine("Naziv\tStanje\tCijena");
                    string a=z.DohvatiSveProizvode();
                    double q = z.IzracunajUkupnuVrijednostZaliha();
                    Console.WriteLine(a + q);
                }

            } while (izbor!="x");
        }
    }
}
