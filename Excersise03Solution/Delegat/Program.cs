using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat
{

    public delegate void trideniJmena();
    public delegate void trideniCisla();
    public delegate void trideniFakulty();


    class Program
    {
        void vypisMenu()
        {
            Console.WriteLine("1) Nacteni studentu z klavesnice.");
            Console.WriteLine("2) Vypis na obrazovku.");
            Console.WriteLine("3) Serazeni podle cisla.");
            Console.WriteLine("4) Serazeni podle jmena.");
            Console.WriteLine("5) Serazei podle fakulty.");
            Console.WriteLine("0) Konec programu.");
        }

        static void Main(string[] args)
        {

            Studenti st = new Studenti();
            Program pr = new Program();

            trideniJmena delegatJmeno = new trideniJmena(st.seradDleJmena);
            trideniCisla delegatCislo = new trideniCisla(st.seradDleCisla);
            trideniFakulty delegatFakulta = new trideniFakulty(st.seradDleFakulty);

            int stiskKlavesa = -1;

            while(stiskKlavesa != 0)
            {
                pr.vypisMenu();

                string vstup = Console.ReadLine();
                stiskKlavesa = int.Parse(vstup);

                switch (stiskKlavesa)
                {
                    case 1:
                        st.nactiStudenty();
                        break;
                    case 2:
                        st.vypisStudenty();
                        break;
                    case 3:
                        delegatCislo();
                        break;
                    case 4:
                        delegatJmeno();
                        break;
                    case 5:
                        delegatFakulta();
                        break;
                    case 0:
                        break;

                }

            }

        }
    }
}
