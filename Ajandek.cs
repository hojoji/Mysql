using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mysql
{
    class Ajandek
    {
        private int id;
        private string nev;
        private string bolt;

        public Ajandek(int id, string nev, string bolt)
        {
            this.id = id;
            this.nev = nev;
            this.bolt = bolt;
        }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Bolt { get => bolt; set => bolt = value; }
    }
}
