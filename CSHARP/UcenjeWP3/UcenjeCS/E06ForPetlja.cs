using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E06ForPetlja
    {
        public static void Izvedi()
        {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Edunova");
            }


            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Edunova " + i);
            }


            //for (int i = 0; i < 1000000; i++)
            //{
            //    Console.WriteLine("Edunova " + i + " " + i + " " + i + " ");
            //}


            int[] niz = { 1, 2, 3, 45, 5, 6, 7, 8, 9 };

            // ispiši sve brojeve jedne ispod drugih

            for (int i = 0;i < niz.Length;i++)
            {
                Console.WriteLine(niz[i]);
            }


            // ispiši sve parne brojeve od 3 do 43
            for (int i = 3; i <= 43; i++) 
            { 
                if (i % 2 == 0) 
                {  
                    Console.WriteLine(i); 
                }
            }


            // koji je zbroj prvih 100 brojeva?
            // 1+2+3+4+...+99+100
            int suma = 0;
            for (int i = 1; i<=100; i++)
            {
                suma += i;
            }
            Console.WriteLine(suma);


            // petlja može ići i unazad
            // ispiši sve brojeve od 82 do 2
            for (int i = 82; i >= 2; i--) 
            {
                Console.WriteLine(i);
            }


            // korak može biti koji želim
            // ispiše svaki broj 7 broj od 1 do 100
            for (int i=1; i<=100; i += 7)
            {
                Console.WriteLine(i);
            }


            // ovaj način nećemo koristiti
            //int j;
            //for (j = 1; j < 10; j++) ;


            // ispiši brojeve od 1 do 25 jedan pored drugog
            for (int i = 1; i <= 25; i++)
            {
                Console.Write(i + " ");
            }


            // petlje se mogu ugnijezditi
            for (int i = 1; i <= 10; i++) 
            {
                for (int j = 1; j <= 10; j++) 
                {
                    Console.Write(i*j + " ");
                }
                Console.WriteLine();
            }








        }
    }
}
