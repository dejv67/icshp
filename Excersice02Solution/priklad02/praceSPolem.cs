using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseLib;

namespace priklad02
{
    class praceSPolem
    {
        int[] pole;

        public praceSPolem()
        {
            pole = new int[5];
        }
        
        public void vypisMenu()
        {
            Console.WriteLine("1. Zadání prvků pole z klávesnice");
            Console.WriteLine("2. Výpis pole na obrazovku");
            Console.WriteLine("3. Utřídění pole vzestupně");
            Console.WriteLine("4. Hledání minimálního prvku");
            Console.WriteLine("5. Hledání prvního výskytu zadaného čísla");
            Console.WriteLine("6. Hledání posledního výskuty zadaného čísla");
            Console.WriteLine("7. Konec programu");
        }

        public void nacteniPrvku()
        {
            Console.WriteLine("Zadejte 5 prvku");
            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = Reading.loadInt();
            }
            Console.WriteLine();
            
        }

        public void vypisPole()
        {
            for (int i = 0; i < pole.Length; i++)
            {
                Console.Write(pole[i] + ", ");
            }
            Console.WriteLine();
        }

        public void utridPole()
        {
            for (int i = 0; i < pole.Length - 1; i++)
            {
                int maxIndex = i;
                for (int j = i+1; j < pole.Length; j++)
                {
                    if (pole[j] > pole[maxIndex])
                        maxIndex = j;
                }
                int tmp = pole[i];
                pole[i] = pole[maxIndex];
                pole[maxIndex] = tmp;
            }
            Console.WriteLine();
        }

        public int najdiMin()
        {
            int minCislo = pole[0];
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] < minCislo)
                {
                    minCislo = pole[i];
                }
            }
            Console.WriteLine();
            return minCislo;

        }

        public int najdiPrvniVyskyt(int cislo)
        {
            int vyskyt = -1;
            for (int i = 0; i < pole.Length; i++)
            {
                if (cislo == pole[i])
                {
                    vyskyt = i;
                    i = pole.Length;
                }
            }
            Console.WriteLine();
            return vyskyt;
        }

        public int najdiPosledniVyskyt(int cislo)
        {
            int vyskyt = -1;
            for (int i = 0; i < pole.Length; i++)
            {
                if (cislo == pole[i])
                {
                    vyskyt = i;
                }
            }
            Console.WriteLine();
            return vyskyt;

        }





    }
}
