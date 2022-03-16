using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Reporter x = new Reporter();
            Sensor y = new Sensor();
            string o=y.GetData();
            DataParser z = new DataParser();
            List<string> q=z.Parse(o);
            Console.WriteLine("Report ");
            x.GenerateReport(q);
            Console.Read();
        }
    }
}
