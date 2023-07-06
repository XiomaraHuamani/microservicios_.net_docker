using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DoctoresController : ControllerBase
    {
        private static readonly Doctores[] TheMenu = new[]
        {
            new Doctores { nombre = "Dereck", apellidos = "Shepherd", especialidad = "Neurologia", turno = "noche", horario = "4:00 -9:00"},
            new Doctores { nombre = "Marck", apellidos = "Sloan", especialidad = "Cirujano plastico", turno = "noche", horario = "4:00 -9:00"},
            new Doctores { nombre = "Cristina", apellidos = "Yang", especialidad = "Cardiologia", turno = "tarde", horario = "4:00 -9:00"},
            new Doctores { nombre = "Meredit", apellidos = "Gray", especialidad = "Cirujia General", turno = "tarde", horario = "4:00 -9:00"},
            new Doctores { nombre = "Alex", apellidos = "Karev", especialidad = "Pediatria", turno = "mañana", horario = "4:00 -9:00"},
            new Doctores { nombre = "Calli", apellidos = "Torres", especialidad = "Ortopedia", turno = "mañana", horario = "4:00 -9:00"}
        };

        private readonly ILogger<DoctoresController> _logger;

        public DoctoresController(ILogger<DoctoresController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Doctores> Get()
        {
            return TheMenu;
        }
    }
}