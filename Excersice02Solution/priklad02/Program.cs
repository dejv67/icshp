using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace priklad02
{
    class Program
    {
        static void Main(string[] args)
        {
            int stiskKlavesa = -1;
            praceSPolem pp = new praceSPolem();

            while(stiskKlavesa != 7)
            {
                pp.vypisMenu();
                Console.Write(": ");
                string nactenoMenu = Console.ReadLine();
                stiskKlavesa = int.Parse(nactenoMenu);

                switch (stiskKlavesa)
                {
                    case 1:
                        pp.nacteniPrvku();
                        break;
                    case 2:
                        pp.vypisPole();
                        break;
                    case 3:
                        pp.utridPole();
                        break;
                    case 4:
                        Console.WriteLine(pp.najdiMin());
                        break;
                    case 5:
                        Console.WriteLine("Zadej hledané číslo: ");
                        string nacteno = Console.ReadLine();
                        int cislo = int.Parse(nacteno);
                        Console.WriteLine(pp.najdiPrvniVyskyt(cislo));
                        break;
                    case 6:
                        Console.WriteLine("Zadej hledané číslo: ");
                        string nacteno2 = Console.ReadLine();
                        int cislo2 = int.Parse(nacteno2);
                        Console.WriteLine(pp.najdiPosledniVyskyt(cislo2));
                        break;
                }
                Console.WriteLine();


            }


        }
    }
}
