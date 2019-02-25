using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv01priklad03
{
    class Program
    {
        static void Main(string[] args)
        {
            string rc;
            Console.WriteLine("Zadej rodné číslo");
            rc = Console.ReadLine();

            string str = rc.Substring(2, 2);
            int month = int.Parse(str);

            Console.WriteLine();

            if (month > 12)
            {
                Console.WriteLine("Rodné číslo patří ženě.");
            }
            else
            {
                Console.WriteLine("Rodné číslo patří muži.");
            }

        }
    }
}
