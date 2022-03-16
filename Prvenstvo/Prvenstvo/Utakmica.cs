using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvenstvo
{
    class Utakmica
    {
        public Reprezentacija domacin;
        public Reprezentacija gost;
        public int zbdom;
        public int zbgost;
        public Utakmica(Reprezentacija domacin,Reprezentacija gost,int zbdom,int zbgost)
        {
            this.domacin = domacin;
            this.gost = gost;
            this.zbdom = zbdom;
            this.zbgost = zbgost;
        }
        public string GenerirajIspis()
        {
            return (domacin + " " + zbdom + ":" + zbgost + " " + gost);
            
        }
    }
}
