using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte název adresáře s absolutní cestou. / Odendtrujte pokud chcete analzyovat aktuální adresář.");
            string adresa = Console.ReadLine();

            if (adresa.Length == 0)
            {
                AdresarovyAnalyzator aa = new AdresarovyAnalyzator();
                aa.zmenaVypisu();
                //aa.analyzuj(".");
                aa.analyzuj("C:\\Users\\David\\Pictures"); // pro testovani
            }
            else
            {
                DirectoryInfo adresar = new DirectoryInfo(adresa);
                if (adresar.Exists)
                {
                    AdresarovyAnalyzator aa = new AdresarovyAnalyzator();
                    aa.zmenaVypisu();
                    aa.analyzuj(adresa);
                }
                else
                {
                    Console.WriteLine("Adresář pod touto adresou neexistuje.");
                }
            }

            
            Console.ReadLine();
        }
    }
}
