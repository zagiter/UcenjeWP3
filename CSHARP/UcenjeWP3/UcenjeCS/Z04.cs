using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z04
    {
        public static void Izvedi() 
        {

            // program od korisnika unosi dva cijela broja i ispisuje sve neparne brojeve
            // između 2 unesena broja

            Console.Write("Unesi broj 1:  ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Unesi broj 2:  ");
            int b = int.Parse(Console.ReadLine());
            int manji = a < b ? a : b;
            int veci = a > b ? a : b;
                for (int i = a; i<= b; i++)
                {
                if (i % 2 == 1) 
                {
                    Console.WriteLine(i);
                }
                }


        }
    }
}
