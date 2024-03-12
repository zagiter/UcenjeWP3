﻿namespace UcenjeCS.E17KonzolnaAplikacija.Model
{
    internal class Smjer : Entitet
    {
        public string Naziv { get; set; }
        public int Trajanje { get; set; }
        public decimal Cijena { get; set; }
        public decimal Upisnina { get; set; }
        public bool Verificiran { get; set; }
    }
}
