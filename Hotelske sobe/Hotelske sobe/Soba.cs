using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelske_sobe
{
    internal class Soba
    {
        public string _Oznaka;
        public int _Kapacitet;
        public enum StatusSobe
        {
            Rezervirana,
            Slobodna
        }

        public StatusSobe _Status;

        public Soba(string oznaka, int kapacitet, StatusSobe status)
        {
            _Oznaka = oznaka;
            _Kapacitet = kapacitet;
            _Status = status;
        }
    }
}
