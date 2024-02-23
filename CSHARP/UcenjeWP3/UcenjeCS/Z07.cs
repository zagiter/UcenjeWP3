using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace UcenjeCS
{
    internal class Z07
    {
        // Program unosi ime osobe, visinu i težinu
        // Program ispisuje crvenom bojom 
        // ako je visina > 170 i < 190 te težina < 90,5
        // Ti, XXXX si zgodan / zgodna

        public static void Izvedi()
        {
            string ime = Pomocno.UcitajString("Unesi ime" );
            int visina = Pomocno.UcitajCijeliBroj("Unesi visinu" );
            float tezina = Pomocno.UcitajDecimalniBroj("Unesi težinu");
            char slovo = 'a';

            
            
                if ((visina > 170) && (visina < 190) && (tezina < 90.5))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    if (ime.Length > 0 && ime[ime.Length - 1] == slovo)
                    {
                        Console.WriteLine(ime + ", zgodna si!");
                    }
                    else
                    {
                        Console.WriteLine(ime + ", zgodan si!");
                    }

                    Console.ResetColor();
                }

        }

    }
}
