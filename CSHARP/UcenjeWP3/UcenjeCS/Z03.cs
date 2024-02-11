using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z03
    {

        public static void Izvedi()
        {
            //Program unosi tri cijela broja
            //Ispisuje najmanji

            Console.Write("Unesi prvi broj:  ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Unesi drugi broj:  ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Unesi treći broj:  ");
            int c = int.Parse(Console.ReadLine());

            if (a < b && a < c)
            {
                Console.WriteLine(a);
            }
            else if (b < a && b < c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }

        }
    }
}

