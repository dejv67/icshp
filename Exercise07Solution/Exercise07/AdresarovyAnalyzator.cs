using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Exercise07
{
    class AdresarovyAnalyzator
    {
        int pocetSouboruCelkem = 0;
        bool vypisovat = false;

        public void analyzuj(string adresarCesta)
        {
            DirectoryInfo adresar = new DirectoryInfo(adresarCesta);
            int pocetSouboru = 0;
            List<typSouboru> pripony = new List<typSouboru>();

            foreach (DirectoryInfo drInfo in adresar.GetDirectories())
            {
                String name = drInfo.Name;

                if (vypisovat == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Jméno                       Velikost(bytes)/Počet souborů           Datum vytvoření");
                    Console.WriteLine("=======================================================================================");

                    //String name = drInfo.Name;
                    int countFiles = drInfo.GetFiles().Length;
                    DateTime creationTime = drInfo.CreationTime;
                    Console.WriteLine("{0, -35:g} {1,-30:N0} {2} ", name, countFiles, creationTime);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(name);
                }
                    
                //Console.WriteLine();
                //Console.WriteLine(name);
                string novaCesta = adresarCesta + "\\" + name;
                analyzuj(novaCesta);
            }

            foreach (FileInfo flInfo in adresar.GetFiles())
            {
                if (vypisovat == true)
                {
                    String name = flInfo.Name;
                    long size = flInfo.Length;
                    DateTime creationTime = flInfo.CreationTime;
                    Console.WriteLine("{0, -35:g} {1,-30:N0} {2} ", name, size, creationTime);

                }

                string pripona = flInfo.FullName;
                string ext = Path.GetExtension(pripona);
                for (int i = 0; i < pripony.Count; i++)
                {
                    if (pripony.ElementAt(i).pripona == ext)
                    {
                        pripony.ElementAt(i).pocet++;
                        break;
                    }else if(i == pripony.Count - 1)
                    {
                        typSouboru novySoubor = new typSouboru(ext, 1);
                        pripony.Add(novySoubor);
                    }
                }

                if (pripony.Count == 0)
                {
                    typSouboru novySoubor = new typSouboru(ext, 1);
                    pripony.Add(novySoubor);
                }

                pocetSouboru++;
            }

            pocetSouboruCelkem = pocetSouboruCelkem + pocetSouboru;
            if (vypisovat == true)
                Console.WriteLine();
            Console.WriteLine("Pocet souboru: " + pocetSouboru);
            for (int i = 0; i < pripony.Count; i++)
            {
                Console.WriteLine(pripony.ElementAt(i).pripona + " " + pripony.ElementAt(i).pocet + "x");
            }
        }

        public void zmenaVypisu()
        {
            Console.WriteLine("Prejete si vypisovat podrobnosti? (ano/ne)");
            string odpoved = Console.ReadLine();
            if (odpoved.Equals("ano"))
                vypisovat = true;
        }
    }
}
