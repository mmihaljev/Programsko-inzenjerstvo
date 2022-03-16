using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    class Reporter
    {
        private double GetMinimalTemperature(List<string> x)
        {
            double min = Convert.ToDouble(x.First());
            foreach(string i in x)
            {
                if (min > Convert.ToDouble(i)) min = Convert.ToDouble(i);
            }
            return min;
        }
        private double GetMaximalTemperature(List<string> x)
        {
            double max = Convert.ToDouble(x.First());
            foreach (string i in x)
            {
                if (max < Convert.ToDouble(i)) max = Convert.ToDouble(i);
            }
            return max;
        }
        private double GetAverageTemperature(List<string> x)
        {
            double zbroj = 0, t = 0;
            foreach(string i in x)
            {
                zbroj += Convert.ToDouble(i);
                t++;
            }
            return zbroj / t;
        }
        public void GenerateReport(List <string> x)
        {
            Console.WriteLine("Prosjecna " + GetAverageTemperature(x) + ", min " + GetMinimalTemperature(x) + ", max " + GetMaximalTemperature(x));
        }
    }
}
