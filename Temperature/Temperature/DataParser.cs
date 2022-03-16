using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    class DataParser
    {
        List<string> temp = new List<string>();
        public List<string> Parse(string sensorData)
        {
            string[] x = new string[100];
            x = sensorData.Split(';');
            foreach(string y in x)
            {
                temp.Add(y);
            }
            return temp;
        }
    }
}
