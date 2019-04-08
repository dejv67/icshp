using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise07
{
    class typSouboru
    {
        public string pripona { get; set; }
        public int pocet { get; set; }

        public typSouboru(string pripona, int pocet)
        {
            this.pripona = pripona;
            this.pocet = pocet;
        }
    }


}
