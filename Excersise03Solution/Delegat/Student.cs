using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat
{
    class Student
    {
        private string jmeno;
        private int cislo;
        private Fakulta fakulta;

        public Student(string jmeno, int cislo, Fakulta fakulta)
        {
            this.jmeno = jmeno;
            this.cislo = cislo;
            this.fakulta = fakulta;
        }

        public string getJmeno()
        {
            return jmeno;
        }

        public int getCislo()
        {
            return cislo;
        }

        public Fakulta getFakulta()
        {
            return fakulta;
        }

        public override string ToString()
        {
            string s = "jméno: " + jmeno + "\n";
            s += "číslo: " + cislo + "\n";
            s += "fakulta: " + fakulta + "\n\n";
            return s;
        }
    }

}
