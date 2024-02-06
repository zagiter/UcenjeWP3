using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E02VarijableTipoviPodatakaOperatori
    {

        public static void Izvedi()
        {
            ////Deklaracija varijable tipa int (cijeli broj)
            //int CijeliBroj;

            //CijeliBroj = 8;

            //Console.WriteLine(CijeliBroj); // korištenje varijable


            //Console.WriteLine("Unesi cijeli broj");
            //int Broj =int.Parse(Console.ReadLine());

            //Console.WriteLine(CijeliBroj +  Broj); // + operator zbrajanja


            ////deklaracija i dodjeljivanje vrijednosti u jednoj liniji
            //string v1 = "Osijek";
            //var v2 = "Edunova"; // ključna riječ var uzima tip podatka s desne strane


            //Console.WriteLine(v1+v2); // + operator nadoljepljivanja

            //float db = 3.14f;

            //double vdb = 0.6549846523123458585;

            //Console.WriteLine("Unesi visinu u metrima");  // možemo na našim računalima koristiti
            //float Visina = float.Parse(Console.ReadLine());


            //Console.WriteLine(Visina);

            //int NajveciBroj = int.MaxValue;

            //Console.WriteLine(NajveciBroj + 1);


            int i = 2, j = 3;

            Console.WriteLine(i - j); //-1
            Console.WriteLine(i * j); //6
            Console.WriteLine(i / (float)j); // 0.666666 (float) -> cast u float tip podatka

            // Iz dvoznamenkastog broja ispiši prvi broj

            Console.Write("Unesi dvoznamenkasti broj: ");
            int dbroj = int.Parse(Console.ReadLine());

            Console.WriteLine(dbroj / 10);

            // Iz dvoznamenkastog broja ispiši drugi broj

            Console.WriteLine(dbroj %10); // modulo je ostatak nakon cjelobrojnog dijeljenja







        }
    }
}