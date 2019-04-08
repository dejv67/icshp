using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    class Hrac
    {
        string jmeno;
        FotbalovyKlub klub;
        int golPocet;

        public Hrac() { }

        public void setJmeno(string jmeno)
        {
            this.jmeno = jmeno;
        }

        public string getJmeno()
        {
            return jmeno;
        }

        public void setKlub(FotbalovyKlub klub)
        {
            this.klub = klub;
        }

        public FotbalovyKlub getKlub()
        {
            return klub;
        }

        public void setGolPocet(int golPocet)
        {
            this.golPocet = golPocet;
        }

        public int getGolPocet()
        {
            return golPocet;
        }
    }
}
