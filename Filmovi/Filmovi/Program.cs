using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmovi
{
    class Program
    {
        static void Main(string[] args)
        {
            string izbor;
            StreamingServis x = new StreamingServis();
            do
            {
                Console.WriteLine("Zelite li prijedlog filma? ");
                izbor = Console.ReadLine();
                if (izbor == "da") x.PredloziFilm();
            } while (izbor!="ne");
            Console.Read();
        }
    }
}
