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
    public class FormularioController : ControllerBase
    {
        private static readonly Formulario [] TheMenu = new[]
        {
            new Formulario { nombre = "Dereck", apellidos = "Shepherd", especialidad = "Neurologia", turno = "noche", horario = "4:00 -9:00"},
            new Formulario { nombre = "Marck", apellidos = "Sloan", especialidad = "Cirujano plastico", turno = "noche", horario = "4:00 -9:00"},
            new Formulario { nombre = "Cristina", apellidos = "Yang", especialidad = "Cardiologia", turno = "tarde", horario = "4:00 -9:00"},
            new Formulario { nombre = "Meredit", apellidos = "Gray", especialidad = "Cirujia General", turno = "tarde", horario = "4:00 -9:00"},
            new Formulario { nombre = "Alex", apellidos = "Karev", especialidad = "Pediatria", turno = "mañana", horario = "4:00 -9:00"},
            new Formulario { nombre = "Calli", apellidos = "Torres", especialidad = "Ortopedia", turno = "mañana", horario = "4:00 -9:00"}
        };

        private readonly ILogger<FormularioController> _logger;

        public FormularioController(ILogger<FormularioController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Formulario> Get()
        {
            return TheMenu;
        }
    }
}