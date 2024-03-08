using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E14VjezbanjeRadaSObjektima
{
    internal class Program
    {
        
        private List<Osoba> Osobe;

        /// <summary>
        /// Kreirati aplikaciju koja unosi, pregledava, mijenja i briše osobe
        /// </summary>

        public Program()
        
        
        {

            // konstruktor služi da bi konstruirao potrebne zavisnosti
            
            Osobe = new List<Osoba>();
            TestPodaci();
            PozdravnaPoruka();
            Izbornik();

        }

        private void TestPodaci()
        {
            Osobe.Add(new() {Ime = "Ivica", Prezime = "Ivić", Dob = 22 });
            Osobe.Add(new() {Ime = "Maja", Prezime = "Perić", Dob = 18 });
        }

        private void PozdravnaPoruka()
        {
            Console.WriteLine("Osobe program V1");
            Console.WriteLine("****************");
        }
        private void Izbornik() 
        {
            Console.WriteLine("1. Pregled osoba");
            Console.WriteLine("2. Unos nove osobe");
            Console.WriteLine("3. Promjena osobe");
            Console.WriteLine("4. Brisanje osobe");
            Console.WriteLine("5. Izlaz iz programa");
            Console.WriteLine("********************");
            OdaberiOpciju();

        }

        private void OdaberiOpciju()
        {
            switch (Pomocno.UcitajCijeliBroj("Odaberi opciju")) 
            {
                case 1:
                    PrikaziOsobe(true);
                    break;
                
                case 2:
                    UnosNoveOsobe();
                    break;

                case 3:
                    PromjenaOsobe();
                    break;
                
                case 4:
                    BrisanjeOsobe();
                    break;

                case 5:
                    Console.WriteLine("Doviđorno!");
                    return;
                
                default:
                    Console.WriteLine("Nije dobroooo :-))");
                    Izbornik();
                    break;

            }
            Izbornik();
        }

        private void BrisanjeOsobe()
        {
            if (Osobe.Count == 0)
            {
                Console.WriteLine("Nema osoba za brisanje");
                Console.WriteLine("**********************");
                return;
            }
            
            Console.WriteLine("** Brisanje osobe ***");
            PrikaziOsobe();
            int izbor = Pomocno.UcitajCijeliBroj("Izaberi broj osobe",1,Osobe.Count);
            Osobe.RemoveAt(izbor - 1);
        }

        private void PromjenaOsobe()
        {
            if (Osobe.Count == 0) 
            {
                Console.WriteLine("Nema osoba za promjenu");
                Console.WriteLine("**********************");
                return;
            }
            
            PrikaziOsobe();
            int izbor = Pomocno.UcitajCijeliBroj("Izaberi broj osobe (0 = ODUSTANI)",0,Osobe.Count);
            if (izbor == 0) 
            {
                return;
            
            }
            var o = Osobe[izbor - 1];
            o.Ime = Pomocno.UcitajString("Ime [" + o.Ime + "]");
            o.Prezime = Pomocno.UcitajString("Prezime [" + o.Prezime + "]");
            o.Dob = Pomocno.UcitajCijeliBroj("Dob [" + o.Dob + "]");
        }

        private void UnosNoveOsobe()
        {
            Osobe.Add(new()
            {
                Ime = Pomocno.UcitajString("Unesi ime osobe"),
                Prezime = Pomocno.UcitajString("Unesi prezime osobe"),
                Dob = Pomocno.UcitajCijeliBroj("Unesi dob osobe: "),
            });
            
        }

        private void PrikaziOsobe(bool PrikaziNaslov=false)
        {
            if (PrikaziNaslov)
            {
                Console.WriteLine("*********************");
                Console.WriteLine("** Osobe u sustavu **");
                Console.WriteLine("*********************");
            }

            if (Osobe.Count == 0) 
            {
                Console.WriteLine("Nema nijedne osobe u sustavu");
                Console.WriteLine("****************************");
                return;
            }
            
            
            int i = 1;
            foreach (var o in Osobe)
            {
                Console.WriteLine(i++ + ". " + o);
            }
            Console.WriteLine("*********************");
        }
    }
}
