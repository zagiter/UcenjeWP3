﻿
namespace UcenjeCS.E17KonzolnaAplikacija
{
    internal class Izbornik
    {
        public ObradaSmjer ObradaSmjer { get; }
        public ObradaPolaznik ObradaPolaznik { get; }

        private ObradaGrupa ObradaGrupa;

        public Izbornik()
        {
            Pomocno.dev = true;
            ObradaSmjer = new ObradaSmjer();
            ObradaPolaznik = new ObradaPolaznik();
            ObradaGrupa = new ObradaGrupa(this);
            //PozdravnaPoruka();
            PrikaziIzbornik();
        }

        //private void PozdravnaPoruka()
        //{
        //    Console.WriteLine("*************************************");
        //    Console.WriteLine("***** Edunova Console APP v1.0 ******");
        //    Console.WriteLine("*************************************");
        //}

        private void PrikaziIzbornik()
        {
            Console.Clear();
            Console.WriteLine("*************************************");
            Console.WriteLine("***** Edunova Console APP v1.0 ******");
            Console.WriteLine("*************************************");
            
            
            Console.WriteLine("---------------");
            Console.WriteLine("Glavni izbornik");
            Console.WriteLine("---------------");
            Console.WriteLine("1. Smjerovi");
            Console.WriteLine("2. Polaznici");
            Console.WriteLine("3. Grupe");
            Console.WriteLine("4. Izlaz iz programa");
            Console.WriteLine("--------------------");
            
            switch (Pomocno.ucitajBrojRaspon("Odaberite stavku izbornika: ",
                "Odabir mora biti 1 - 4.", 1, 4))
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
                    Console.WriteLine("*******************************");
                    Console.WriteLine("Hvala na korištenju, doviđenja!");
                    Console.WriteLine("*******************************");
                    break;

            }



        }

    }
}