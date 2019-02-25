using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv01priklad04
{
    class Program
    {
        static void Main(string[] args)
        {
            // generovani čisla
            int end = 0;
            while (end == 0){

                Random rnd = new Random();
                int cislo = rnd.Next(0, 101);

                for (int i = 0; i < 10; i++)
                {

                    Console.WriteLine("Zadej číslo.");
                    string str = Console.ReadLine();
                    int tip = int.Parse(str);
                    Console.WriteLine("");

                    if (tip == cislo)
                    {
                        Console.WriteLine("BINGO!");
                        i = 11;
                    }
                    else if (tip < cislo)
                    {
                        Console.WriteLine("Zkus větší.");
                    }
                    else if (tip > cislo)
                    {
                        Console.WriteLine("Zkus menší");
                    }

                    if (i == 10)
                    {
                        Console.WriteLine("Prohrál jsi...");
                    }
                }

                Console.WriteLine("Pokud ukončení zmáčnkni 1. Pro opakování zmáčni 0.");
                string st = Console.ReadLine();
                end = int.Parse(st);
            }
        }
    }
}
