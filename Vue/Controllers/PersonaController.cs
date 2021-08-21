using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vue.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {

        [HttpGet]
        public Persona Get()
        {
            Persona oPersona = new Persona() { Nombre = "Geovanny" };

            return oPersona;
        }
    }

    public class Persona
    {
        public string Nombre { get; set; }
    }
}
