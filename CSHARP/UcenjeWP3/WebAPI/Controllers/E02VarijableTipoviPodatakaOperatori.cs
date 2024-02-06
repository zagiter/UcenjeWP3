using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E02")]
    public class E02VarijableTipoviPodatakaOperatori:ControllerBase
    {

        // ovdje počinje ruta
        [HttpGet]
        [Route("zad1")]
        public int Zad1(int prvi, int drugi)
        {
            return prvi + drugi;
        }
        // ovdje završava ruta
        

    }
}