using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E02")]
    public class E02VarijableTipoviPodatakaOperatori : ControllerBase
    {

        // ovdje počinje ruta
        [HttpGet]
        [Route("zad1")]
        public int Zad1()
        {
            return int.MaxValue;
        }
        // ovdje završava ruta




        // ovdje počinje ruta
        [HttpGet]
        [Route("zad2")]
        public float Zad2(int a, int b)
        {
            // ruta prima kvocijent dvaju primljenih brojeva
            return a / (float)b;
        }
        // ovdje završava ruta zz

        [HttpGet]
        [Route("zad3")]
        public float Zad3(int a, int b)
        {

            return (a * b) + (a / (float)b);
        }

        [HttpGet]
        [Route("zad5")]
        public string Zad5(string a, string b)
        {

            return a + " " + b;

        }
    }
}