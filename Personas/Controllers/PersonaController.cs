using Microsoft.AspNetCore.Mvc;
using Personas.BL;

namespace Personas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonaController : Controller
    {
        private readonly iPersona _per;
        public PersonaController(iPersona per) {
            _per = per;
        }
        //PersonaBL _per = new PersonaBL();
        
        [HttpGet]
        public IActionResult get()
        {
            var persona = _per.GetPersona();
            return Ok(persona);
        }
        [HttpGet("{sexo}")]

        public IActionResult get(string sexo)
        {
            if (sexo.Equals("T"))
            {
                var obj = new[] { 
                    new { MASCULINO = _per.PersonasPorSexo("M"), FEMENINO = _per.PersonasPorSexo("F") }
                };
                return Ok(obj);    
            }
            else {
                return Ok(_per.PersonasPorSexo(sexo));
            }
        }
    }
}
