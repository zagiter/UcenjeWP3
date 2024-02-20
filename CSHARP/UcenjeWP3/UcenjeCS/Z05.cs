using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z05
    {
        public static void Izvedi() 
        {
            // Program od korisnika unosi cijeli broj
            // ispisuje zbroj svih brojeva od 1 do unesenog broja
            // primjer za 100 će ispisati 5050
            
            int k, broj = int.MaxValue; 
            Console.WriteLine("Unesi broj: ");
            broj = int.Parse(Console.ReadLine());
            int suma = 0;
            for (k = 1; k <= broj; k++)
            {
                suma += k;
            }
            Console.WriteLine(suma);



            // Program unosi cijele brojeve sve dok se ne unese -1
            // ispisuje najmanji unešeni broj

            int i, najmanji = int.MaxValue;

            for (; ; )
            {
                Console.WriteLine("Unesi broj: ");
                i = int.Parse(Console.ReadLine());
                if (i == -1)
                {
                    break;
                }
                if (i < najmanji)
                {
                    najmanji = 1;
                }
            }
            Console.WriteLine(najmanji);



             // Program unosi cijeli broj
             // ispisuje da li je uneseni broj prosti(prim) prime(eng.) ili ne

            {
                Console.WriteLine("Unesi broj: ");
                int b = int.Parse(Console.ReadLine());
                bool prim = true;
                for (int j = 2; j < b; j++)
                {
                    if (b % j == 0)
                    {
                        prim = false;
                        break; // ušteda nepotrebnih iteracija
                    }

                }
                Console.WriteLine(b + " " + (prim ? " JE " : " NIJE ") + "prim broj");

            }

        }

    }

}
