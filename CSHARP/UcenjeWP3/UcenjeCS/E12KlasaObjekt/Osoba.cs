using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E12KlasaObjekt
{
    // klasa je opisnik objekta :-)
    internal class Osoba
    {
        // klasa sadrži svojstva

        public string? Ime { get; set; } // OOP princip: učahurivanje
        public string? Prezime { get; set; } 

        // klasa sadrži metode
        public string ImePrezime()  // ova metoda se može pozvati na objektu, ne na klasi
        {
            return Ime + " " + Prezime;
        }

        public static void Izvedi() // ova metoda se može pozvati na klasi, ne na objektu
        {


        }


    }
}
