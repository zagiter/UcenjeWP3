using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E04")]
    public class E04Petlje : ControllerBase
    {

        // ovdje počinje ruta
        [HttpGet]
        [Route("zad1")]
        public int Zad1(int a, int b)
        {
            // Ruta prima dva cijela broja
            // ruta vraća zbroj svih parnih brojeva između dva primljena broja
            int zbroj = 0;

            for (int i = a; i <= b; i++)
            {
                if (i % 2 ==0)
                { 
                    zbroj++; 
                }
            }
            
            return zbroj;
            
   


        }
        // ovdje završava ruta


    }
}