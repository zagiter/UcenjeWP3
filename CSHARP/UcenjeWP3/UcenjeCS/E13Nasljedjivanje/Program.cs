using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E13Nasljedjivanje
{

    
    internal class Program
    {
    
        
        // 5. vrsta metode: KONSTRUKTOR

    public Program()
        {
            Console.WriteLine("Gdje sam tooo :-)");


            // U kontruktoru se pripreme potrebne zavisnosti


            Primjer1();

            Primjer2();

            Primjer3();

            Primjer4();

            Primjer5();
        }

        private void Primjer1()
        {
            Predavac p = new Predavac();
            p.Ime = "Mirko";
            p.Iban = "HR455";

            Polaznik polaznik = new Polaznik();
            polaznik.Ime = "Marta";
            polaznik.BrojUgovora = "12/2023";

            // Ispiši HR455
            Console.WriteLine(p.Iban);
        }

        private void Primjer2()
        {
            // Ne može se instancirati apstraktna klasa
            // Osoba osoba = new Osoba();
            
            OsobaImpl osoba = new OsobaImpl();
            osoba.Ime = "Toma";

            osoba.GetType();  // Metoda GetType dolazi iz klase Object 
        }
    
        // korištenje ToString metode
        private void Primjer3()
        {
            var p = new Predavac()
            {
                Ime="Marko",
                Prezime="Markić",
                Iban="HR22"
            };
            
            Console.WriteLine(p);

            Console.WriteLine(new Polaznik() { Ime="Ranko", Prezime="Rankić", BrojUgovora="1"});
        }
    
        // korištenje hashCode metode

        private void Primjer4()
        {
            Polaznik p1 = new() { Ime = "Iva" };
            Polaznik p2 = new() { Ime = "Iva" };

            Console.WriteLine(p1==p2);

            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p2.GetHashCode());
        }
    
        // Specifičnost string klase
        private void Primjer5()
        {
            string s = "Osijek";
            var grad = new string("Osijek");

            // string je immutable
            Console.WriteLine(s.GetHashCode());
            s = s + " je ok";
            // ne dobijem isti hashcode jer svaka manipulacija sa stringom u memoriji kreira nove varijable
            Console.WriteLine(s.GetHashCode());
        
        
            // U radu sa stringovima preporuča se korištenje klase StringBuilder
        
            StringBuilder sb = new StringBuilder();
            
            Console.WriteLine(s.GetHashCode());
            
            sb.Append("Osijek");
            Console.WriteLine(sb.GetHashCode());
            sb.Append(" je super");
            Console.WriteLine(sb.GetHashCode());

            Console.WriteLine(sb);  // poziva se metoda ToString




        }
    
    
    }
}
