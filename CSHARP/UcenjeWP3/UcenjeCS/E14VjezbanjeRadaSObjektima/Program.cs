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
            switch (Pomocno.UcitajCijeliBroj("Odaberi opciju: ")) 
            {
                case 1:
                    PrikaziOsobe();
                    Izbornik();
                    break;
                
                case 2:
                    UnosNoveOsobe();
                    Izbornik();
                    break;

                case 5:
                    Console.WriteLine("Doviđorno!");
                    break;
                
                default:
                    Console.WriteLine("Nije dobroooo :-))");
                    Izbornik();
                    break;

            }
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

        private void PrikaziOsobe()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("** Osobe u sustavu **");
            Console.WriteLine("*********************");
            foreach (var o in Osobe)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("*********************");
        }
    }
}
