using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E13Nasljedjivanje
{
    // Apstraktna klasa je ona koja nema implementaciju (instancu)
    // Koristi se za objedinjavanje zajedničkih svojstava i metoda koje će netko naslijediti
    internal abstract class Osoba
    {
        public string? Ime { get; set; }
        public string? Prezime { get; set; }

    }
}
