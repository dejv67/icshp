using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grettings
{
    class Program
    {
        
         // prace se cvicicim
         static uint DEFAULT_COUNT = 100;
         static uint GetCount(string[] args)
         {
             if (args.Length == 0) return DEFAULT_COUNT;
             uint temp;
             if (uint.TryParse(args[0], out temp))
                 return temp;
             return DEFAULT_COUNT;
         }

         static void Main(string[] args)
         {
             Console.Write("Hello world");
             Console.WriteLine("Hello world again!");
             uint count = GetCount(args);
             string grettings = "Hello world ";
             if (count != 0)
             {
                 for (uint i = 1; i < count - 1; i++)
                 {
                     grettings += "again ";
                 }
             }
             grettings += "again!";
             Console.WriteLine(grettings);
            
         }

    }
}
