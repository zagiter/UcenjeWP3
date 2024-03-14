using EdunovaAPP.Data;
using Microsoft.AspNetCore.Mvc;

namespace EdunovaAPP.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]

    public class SmjerController 
    {

        private readonly EdunovaContext _context;
        
            // Dependency injection
            // U konstruktoru prima instancu i doddijeljeje privatnom svojstvu

        public SmjerController(EdunovaContext context)     
        { 
            _context = context;
        }
        
        
        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult(_context.Smjerovi.ToList());
        }
    
    
    
    }
    
    
}
