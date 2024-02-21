using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E10Metode
    {
        // static označava da METODU mogu pozvati na KLASI
        // public se vidi u svim klasama
        public static void Izvedi()
        {
            
            //for (int i = 0; i < 5; i++)
            //{
                // ovdje sam je pozvao
                Tip1();
                // ovdje je zovem drugi puta
                Tip1();
            // }

                Tip2("Zagi");
                Tip2("Pero", "Perić");

                Tip3();  // metoda će se izvesti, ali ono što vraća ode u zaborav

            Console.WriteLine(Tip3());
            Console.WriteLine(Tip4(3,88));


        }

        // TIP 1. Metoda ne prima parametre i ne vraća vrijednost
        // ovdje je deklarirana, napisana
        // PRIVATE se vidi samo u trenutnoj klasi
        private static void Tip1()
        {
            Console.WriteLine("Bok iz metode koja nije primila parametre i ne vraća vrijednost!");
        }


        // TIP 2. metoda prima parametre i ne vraća vrijednost
        // kada ispred [static] void nema način pristupa, tada je private
     
        static void Tip2(string ime)
        {
            Console.WriteLine("Bok " + ime);
        }

        // Naziv metode ne mora biti jedinstven
        // POTPIS METODE: naziv + lista parametara
        // method signature
        // method overloading

        static void Tip2(string ime, string prezime)
        {
            Console.WriteLine("Bok " + ime + " " + prezime);
        }

        // TIP 3. metoda ne prima parametre i vraća vrijednost
        // INTERNAL je vidljivo u trenutnom namespace-u

        internal static int Tip3()
        {
            return '5'; // vraća prema ASCII tablici
        }

        // TIP 4. NAJBITNIJI - metoda prima parametre, metoda vraća vrijednost
        // protected je vidljiv u ovoj klasi u svim podklasama (OOP - kasnije)
        /// <summary>
        /// Primjer metode koja prima 2 parametra i vraća vrijednost
        /// </summary>
        /// <param name="odBroja">prvi primljeni parametar od kojeg se kreće</param>
        /// <param name="doBroja">drugi primljeni parametar do kojeg se ide (<=)</param>
        /// <returns>ZBROJ svakog drugog broja između dva primljena</returns>


        protected static int Tip4(int odBroja, int doBroja)
        {
            int suma = 0;
            for (int i = odBroja; i <= doBroja; i += 2) 
            {
                suma += i;
            
            }
            return suma;
        }
    
    }
}
