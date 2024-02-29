using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using UcenjeCS.E12KlasaObjekt.Edunova;

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

            osoba.Ime = "Marko"; //Pomocno.UcitajString("Unesi ime osobe");
            osoba.Prezime = "Mikić";

            Console.WriteLine(osoba.ImePrezime());

            osoba = new Osoba
            {
                Ime = "Ivana",  //Pomocno.UcitajString("Unesi ime"),
                Prezime = "Malić"
            };

            Osoba o = new()
            {
                Ime = "Maja",
                Prezime = "Majić"
            };


            var direktor = new Osoba() {Prezime = "Kas"};

            var m = new Mjesto() {Naziv = "Osijek"};

            direktor.Mjesto = m;
            
            Console.WriteLine(direktor.Mjesto.Naziv);




            var s = new Smjer()
            {
                Naziv = "Web programiranje",
                Trajanje = 135,
                Cijena = 1234.55m,
                Sifra = 1,
                Vaucer = true
            };


            Predavac[] predavaci =
            {
                new (){Ime = "Mali", Prezime = "Ivica"},
                new Predavac(){Ime = "Iva", Prezime = "Ivic"}
            };



            Grupa g = new Grupa();
            g.Naziv = "WP3";
            // Grupa WP3 je na smjeru Web programiranje
            g.Smjer = s;
            // Grupu WP3 vodi Iva
            g.Predavac = predavaci[1];

           
            // Ispiši  135 sa varijable g
            Console.WriteLine(g.Smjer.Trajanje);

        }
    }
}
