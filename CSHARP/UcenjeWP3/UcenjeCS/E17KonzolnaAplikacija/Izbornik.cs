﻿
namespace UcenjeCS.E17KonzolnaAplikacija
{
    internal class Izbornik
    {
        public ObradaSmjer ObradaSmjer { get; }
        public ObradaPolaznik ObradaPolaznik { get; }
        private ObradaPredavac ObradaPredavac { get; }
        
        private ObradaGrupa ObradaGrupa;

        
        public Izbornik()
        {
            Pomocno.dev = true;
            ObradaSmjer = new ObradaSmjer();
            ObradaPolaznik = new ObradaPolaznik();
            ObradaGrupa = new ObradaGrupa(this);
            ObradaPredavac = new ObradaPredavac();
            
            PrikaziIzbornik();
        }

        private void PrikaziIzbornik()
        {
            Console.Clear();
            Console.WriteLine("*************************************");
            Console.WriteLine("***** Edunova Console APP v1.0 ******");
            Console.WriteLine("*************************************");
            Console.WriteLine("\t");

            Console.WriteLine("---------------");
            Console.WriteLine("Glavni izbornik");
            Console.WriteLine("---------------");
            Console.WriteLine("1. Smjerovi");
            Console.WriteLine("2. Polaznici");
            Console.WriteLine("3. Grupe");
            Console.WriteLine("4. Predavači");
            Console.WriteLine("5. Izlaz iz programa");
            Console.WriteLine("--------------------");
            Console.WriteLine("\t");
            
            
            switch (Pomocno.ucitajBrojRaspon("Odaberite stavku izbornika: ",
                "Odabir mora biti 1 - 5.", 1, 5))
            {
                case 1:
                    Console.Clear();
                    ObradaSmjer.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 2:
                    Console.Clear();
                    ObradaPolaznik.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 3:
                    Console.Clear();
                    ObradaGrupa.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 4:
                    Console.Clear();
                    ObradaPredavac.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("*******************************");
                    Console.WriteLine("Hvala na korištenju, doviđenja!");
                    Console.WriteLine("*******************************");
                    break;

            }



        }

    }
}