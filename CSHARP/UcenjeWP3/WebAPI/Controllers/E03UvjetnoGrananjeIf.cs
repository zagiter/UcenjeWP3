﻿using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E03")]
    public class E03UvjetnoGrananjeIf : ControllerBase
    {

        // ovdje počinje ruta
        [HttpGet]
        [Route("zad1")]
        public int Zad1(int a, int b)
        {
            // Ruta prima dva cijela broja
            // Ako je zbroj primljenih brojeva paran broj vraća njihov umnožak
            // inače vraća njihov zbroj
            return (a+b)%2==0 ? a*b : a+b;  // PREGLEDNIJE, JEDNOSTAVNIJE :)

            //var zbroj = a + b;
            //if (zbroj % 2 == 0)
            //{
            //    return a + b;
            //}
            //else 
            //{
            //    return zbroj;
            //}



        }
        // ovdje završava ruta





        // ovdje počinje ruta
        [HttpGet]
        [Route("zad2")]
        public string Zad2(int ocjena)
        {
            // Ruta prima brojčanu ocjenu
            // Ruta daje slovnu ocjenu

        
            
            switch (ocjena)
            {
                case 1:
                    return "Nedovoljan";
                case 2:
                    return "Dovoljan";
                case 3:
                    return "Dobar";
                case 4:
                    return "Vrlo dobar";
                case 5:
                    return "Odličan";
                default:
                    return "Nije ocjena";
                   
            }

        }
        // ovdje završava ruta
    }
}