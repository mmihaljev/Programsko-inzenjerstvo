using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvenstvo
{
    class Prvenst
    {
        List<Reprezentacija> repke = new List<Reprezentacija>();
        List<Utakmica> utkm = new List<Utakmica>();
        public Prvenst()
        {
            repke.Add(new Reprezentacija("CRO", "Hrvatska"));
            repke.Add(new Reprezentacija("ARG", "Argentina"));
            repke.Add(new Reprezentacija("NIG", "Nigerija"));
            repke.Add(new Reprezentacija("ISL", "Island"));
            utkm.Add(new Utakmica(repke[0], repke[1], 3, 0));
            utkm.Add(new Utakmica(repke[0], repke[3], 2, 1));
            utkm.Add(new Utakmica(repke[2], repke[0], 0, 2));
            utkm.Add(new Utakmica(repke[1], repke[3], 1, 1));
            utkm.Add(new Utakmica(repke[2], repke[1], 1, 2));
            utkm.Add(new Utakmica(repke[3], repke[2], 0, 2));
        }
        public void GenerirajTablicuRezultata()
        {
            foreach(Utakmica i in utkm)
            {
                Console.WriteLine(i.GenerirajIspis());
            }
        }
        public void GenerirajBodovnuLjestvicu()
        {
            Console.WriteLine("REP\tOU\tPOB\tNER\tIZG\tPOZ\tPRZ\tRUZ\tBOD");
            Console.WriteLine(repke[0]);
            int[] x = new int[4];
            x[0] = Odredi_BR(repke[0]);
            x[1] = Odredi_BR(repke[1]);
            x[2] = Odredi_BR(repke[2]);
            x[3] = Odredi_BR(repke[3]);
            for(int i = 0; i < 4; i++)
            {
                int max = FindMax(x);
                x[max] = 0;
                Console.WriteLine(repke[max].oznaka + "\t" + Odredi_OU(repke[max]) + "\t" + Odredi_POB(repke[max]) + "\t" + Odredi_NER(repke[max]) + "\t" + Odredi_IZG(repke[max]) + "\t" + Odredi_POZ(repke[max]) + "\t" + Odredi_PRZ(repke[max]) + "\t" + Odredi_PR(repke[max])+"\t"+Odredi_BR(repke[max]));
            }
            
        }
        public int Odredi_OU(Reprezentacija rep)
        {
            int ou = 0;
            foreach(Utakmica i in utkm)
            {
                if (rep == i.domacin || rep == i.gost) ou++;
            }
            return ou;
        }
        public int Odredi_POB(Reprezentacija rep)
        {
            int pob = 0;
            foreach(Utakmica i in utkm)
            {
                if (rep == i.domacin && i.zbdom > i.zbgost) pob++;
                else if (rep == i.gost && i.zbgost > i.zbdom) pob++;
            }
            return pob;
        }
        public int Odredi_NER(Reprezentacija rep)
        {
            int x = 0;
            foreach (Utakmica i in utkm)
            {
                if ((rep == i.gost || rep == i.domacin) && (i.zbdom == i.zbgost)) x++;
            }
            return x;
        }
        public int Odredi_IZG(Reprezentacija rep)
        {
            int izg = 0;
            foreach(Utakmica i in utkm)
            {
                if (rep == i.domacin && i.zbdom < i.zbgost) izg++;
                else if (rep == i.gost && i.zbgost < i.zbdom) izg++;
            }
            return izg;
        }
        public int Odredi_POZ(Reprezentacija rep)
        {
            int pos = 0;
            foreach(Utakmica i in utkm)
            {
                if (rep == i.domacin) pos+=i.zbdom;
                else if (rep == i.gost) pos+=i.zbgost;
            }
            return pos;
        }
        public int Odredi_PRZ(Reprezentacija rep)
        {
            int prz = 0;
            foreach(Utakmica i in utkm)
            {
                if (rep == i.domacin) prz += i.zbgost;
                else if (rep == i.gost) prz += i.zbdom;
            }
            return prz;
        }
        public int Odredi_PR(Reprezentacija rep)
        {
            int x=Odredi_POZ(rep);
            int y = Odredi_PRZ(rep);
            return x - y;
        }
        public int Odredi_BR(Reprezentacija rep)
        {
            int x = Odredi_POB(rep);
            int y = Odredi_NER(rep);
            x *= 3;
            return x + y;
        }
        public int FindMax(int[] x)
        {
            int max = x[0], rj = 0;
            for(int i = 0; i < x.Length; i++)
            {
                if (x[i] > max)
                {
                    max = x[i];
                    rj = i;
                }
            }
            return rj;
        }
    }
}
