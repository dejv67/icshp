using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat
{
    class Studenti
    {
        Student[] poleStudentu;

        public Studenti()
        {
            poleStudentu = new Student[3];
        }

        public void nactiStudenty()
        {
            for (int i = 0; i < poleStudentu.Length; i++)
            {
                bool fakultaCorrect = false;
                string fakulta;
                Fakulta fak2 = 0;
               
                Console.WriteLine("Zadej jmeno " + (i+1) + ". studenta");
                string jmeno = Console.ReadLine();
                Console.WriteLine("Zadej cislo " + (i+1) + ". studenta");
                string cislo = Console.ReadLine();                
                while(fakultaCorrect == false)
                {
                    Console.WriteLine("Zadej fakultu " + (i+1) + ". studenta (zkratka velkymi pismeny)");
                    fakulta = Console.ReadLine();

                    string[] seznamFakult = Enum.GetNames(typeof(Fakulta));
                    
                    for (int j = 0; j < seznamFakult.Length; j++)
                    {
                        if (fakulta.Equals(seznamFakult[j])){
                            fakultaCorrect = true;
                            fak2 = (Fakulta)j;
                            break;
                        }
                    }
                }
                Student st = new Student(jmeno, int.Parse(cislo), fak2);
                poleStudentu[i] = st;

            }
        }

        public void vypisStudenty()
        {
            for (int i = 0; i < poleStudentu.Length; i++)
            {
                Console.WriteLine(poleStudentu[i].ToString());
            }
        }

        public void seradDleCisla()
        {
            for (int i = 0; i < poleStudentu.Length-1; i++)
            {
                int minIndex = i;
                for (int j = i; j < poleStudentu.Length; j++)
                {
                    if (poleStudentu[j].getCislo() < poleStudentu[minIndex].getCislo())
                        minIndex = j;
                }
                Student tmp = poleStudentu[i];
                poleStudentu[i] = poleStudentu[minIndex];
                poleStudentu[minIndex] = tmp;
            }
        }

        public void seradDleJmena()
        {
            for (int i = 0; i < poleStudentu.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i; j < poleStudentu.Length; j++)
                {
                    if (poleStudentu[j].getJmeno().CompareTo(poleStudentu[minIndex].getJmeno()) == -1)
                        minIndex = j;
                }
                Student tmp = poleStudentu[i];
                poleStudentu[i] = poleStudentu[minIndex];
                poleStudentu[minIndex] = tmp;
            }
        }

        public void seradDleFakulty()
        {
            for (int i = 0; i < poleStudentu.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i; j < poleStudentu.Length; j++)
                {
                    if (poleStudentu[j].getFakulta().ToString().CompareTo(poleStudentu[minIndex].getFakulta().ToString()) == -1)
                        minIndex = j;
                }
                Student tmp = poleStudentu[i];
                poleStudentu[i] = poleStudentu[minIndex];
                poleStudentu[minIndex] = tmp;
            }
        }

    }
}
