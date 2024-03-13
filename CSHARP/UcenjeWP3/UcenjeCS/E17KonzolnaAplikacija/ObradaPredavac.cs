﻿using UcenjeCS.E17KonzolnaAplikacija.Model;


namespace UcenjeCS.E17KonzolnaAplikacija
{
    internal class ObradaPredavac
    {
        public List<Predavac> Predavaci { get; }
        public ObradaPredavac()
        {
            Predavaci = new List<Predavac>();
            if (Pomocno.dev)
            {
                TestniPodaci();
            }

        }
        public void PrikaziIzbornik()
        {

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Izbornik za rad s predavačima");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1. Pregled postojećih predavača");
            Console.WriteLine("2. Unos novog predavača");
            Console.WriteLine("3. Promjena postojećeg predavača");
            Console.WriteLine("4. Brisanje predavača");
            Console.WriteLine("5. Povratak na glavni izbornik");
            Console.WriteLine("------------------------------");
            Console.WriteLine("\t");
            switch (Pomocno.ucitajBrojRaspon("Odaberite stavku izbornika predavača: ",
                "Odabir mora biti 1-5", 1, 5))
            {

                case 1:
                    Console.Clear();
                    PregledPredavaca();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UcitajPredavaca();
                    Console.Clear();
                    PrikaziIzbornik();
                    break;
                case 3:
                    PromjenaPredavaca();
                    Console.Clear();
                    PrikaziIzbornik();
                    break;
                case 4:
                    BrisanjePredavaca();
                    Console.Clear();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.WriteLine("Gotov rad s predavačima");
                    break;
           }
        }

        private void PromjenaPredavaca()
        {
            PregledPredavaca();
            int index = Pomocno.ucitajBrojRaspon("Odaberi redni broj predavača: ", "Nije dobar odabir", 1, Predavaci.Count());
            var p = Predavaci[index - 1];
            p.Sifra = Pomocno.ucitajCijeliBroj("Unesite šifru predavača (" + p.Sifra + "): ",
                "Unos mora biti pozitivni cijeli broj");
            p.Ime = Pomocno.UcitajString("Unesi ime predavača (" + p.Ime + "): ", "Ime obavezno");
            p.Prezime = Pomocno.UcitajString("Unesi prezime predavača (" + p.Prezime + "): ", "Prezime obavezno");
            p.Email = Pomocno.UcitajString("Unesi Email predavača (" + p.Email + "): ", "Email obavezan");
            p.Oib = Pomocno.UcitajString("Unesi OIB predavača (" + p.Oib + "): ", "OIB obavezan");
            p.Iban = Pomocno.UcitajString("Unesi IBAN predavača: ", "IBAN obavezan");
        }

        private void BrisanjePredavaca()
        {
            PregledPredavaca();
            int index = Pomocno.ucitajBrojRaspon("Odaberi redni broj predavača: ", "Nije dobar odabir", 1, Predavaci.Count());
            Predavaci.RemoveAt(index - 1);
        }

        public void PregledPredavaca()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("---- Predavači ----");
            Console.WriteLine("-------------------");
            int b = 1;
            foreach (Predavac predavac in Predavaci)
            {
                Console.WriteLine("{0}. {1} {2} ({3})", b++, predavac.Ime, predavac.Prezime, predavac.Email);
            }
            Console.WriteLine("-------------------");
            Console.WriteLine("\t");
        }

        private void UcitajPredavaca()
        {
            var p = new Predavac();
            p.Sifra = Pomocno.ucitajCijeliBroj("Unesite šifru predavača: ",
                "Unos mora biti pozitivni cijeli broj");
            p.Ime = Pomocno.UcitajString("Unesi ime predavača: ", "Ime obavezno");
            p.Prezime = Pomocno.UcitajString("Unesi prezime predavača: ", "Prezime obavezno");
            p.Email = Pomocno.UcitajString("Unesi Email predavača: ", "Email obavezan");
            p.Oib = Pomocno.UcitajString("Unesi OIB predavača: ", "OIB obavezan");
            p.Iban = Pomocno.UcitajString("Unesi IBAN predavača: ", "IBAN obavezan");
            Predavaci.Add(p);

        }
        private void TestniPodaci()
        {

            Predavaci.Add(new Predavac
            {
                Sifra = 1,
                Ime = "Tomislav",
                Prezime = "Jakopec",
                Email = "tjakopec@nekimail.com",
                Oib = "33736472822",
                Iban = "12343344"
            });

            Predavaci.Add(new Predavac
            {
                Sifra = 2,
                Ime = "Eduard",
                Prezime = "Kuzma",
                Email = "edo@gmail.com",
                Oib = "33736472821",
                Iban = "654654654"
            });
        }

    }
}