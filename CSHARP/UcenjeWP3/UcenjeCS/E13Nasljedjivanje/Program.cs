using System;
using System.Collections.Generic;
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
            // Ne može se instancirti apstraktna klasa
            // Osoba osoba = new Osoba();
            
            OsobaImpl osoba = new OsobaImpl();
            osoba.Ime = "Toma";
        }
    }
}
