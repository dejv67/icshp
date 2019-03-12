using System;

namespace BaseLib
{
    public static class Reading
    {
        public static int loadInt()
        {
            Console.WriteLine("Zadej celé číslo: ");
            string cislo = Console.ReadLine();
            int cislo2 = int.Parse(cislo);
            return cislo2;
        }

        public static double loadDouble()
        {
            Console.WriteLine("Zadej číslo: ");
            string cislo = Console.ReadLine();
            double cislo2 = double.Parse(cislo);
            return cislo2;
        }

        public static string loadString()
        {
            Console.WriteLine("Zadej řetězec: ");
            string retezec = Console.ReadLine();
            return retezec;
        }

        public static int loadChar()
        {
            Console.WriteLine("Zadej znak: ");
            string znak = Console.ReadLine();
            char znak2 = char.Parse(znak);
            return znak2;
        }
    }
}
