using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace UcenjeCS.E12KlasaObjekt
{
    internal class Program
    {
        public static void Izvedi()
        {
            // Objekt je instanca (pojavnost) klase
            // Osoba je klasa
            // o je instanca klase (objekt, varijabla)
            
            Osoba osoba = new Osoba();

            osoba.Ime = Pomocno.UcitajString("Unesi ime osobe");
            osoba.Prezime = "Mikić";

            Console.WriteLine(osoba.ImePrezime());

           
        }
    }
}
