using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E05Nizovi
    {
        public static void Izvedi()
        {
            // eng. Arrays
            
            // JEDNODIMENZIONALNI NIZOVI
            

            int[] Temperature = new int[6];   // integer
            Temperature[0] = 1;  // [0] ovo je indeks niza, 1 je vrijednost
            Temperature[Temperature.Length-1] = 2;  // zadnje mjesto

            Console.WriteLine(Temperature);
            Console.WriteLine(string.Join(",",Temperature));

            string[] Gradovi = new string[3];   // string
            Gradovi[0] = "Osijek";
            Gradovi[1] = "Zagreb";
            Gradovi[2] = "Varaždin";

            Console.WriteLine(string.Join(" ",Gradovi));

            // skraćeni način definiranja niza
            int[] brojevi = { 2, 3, 2, 5, 8, 4 };

            // ispiši broj 5
            Console.WriteLine(brojevi[3]);

            // prvi element niza
            Console.WriteLine(brojevi[0]);

            // zadnji element niza
            Console.WriteLine(brojevi[brojevi.Length-1]);


            // DVODIMENZIONALNI NIZ - matrica (tablica)

            int[,] tablica =
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            // Ispisati 6
            Console.WriteLine(tablica[1,2]);

            // TRODIMENZIONALNI NIZ (KOCKA)
            int[,,] kocka = new int[10,10,10];

            // VIŠEDIMENZIONALNI NIZ
            //int[,,,,,] zvjezdaneStaze;

            string grad = "Osijek";

            // Ispiši i
            Console.WriteLine(grad[2]);  // ispisao je char tip podatka

            char znak = 'i';
            
            Console.WriteLine(znak);
            
            Console.WriteLine((int)znak);


            int[] niz = { 1, 2, 3, 4, 5 };

            // ispiši sve elemente niza jedno ispod drugog
            Console.WriteLine(niz[0]);
            Console.WriteLine(niz[1]);
            Console.WriteLine(niz[2]);
            Console.WriteLine(niz[3]);
            Console.WriteLine(niz[4]);

            int i = 0;
            // uvećaj i za 1

            i=i+1;
            i += 1;
            i++; // ++i





        }
    }
}
