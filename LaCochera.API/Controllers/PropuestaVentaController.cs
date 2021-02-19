using LaCochera.BL.Contracts;
using LaCochera.Core.DTO;
using LaCochera.Core.DTO.Ventas;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LaCochera.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PropuestaVentaController : ControllerBase
    {

        public IPropuestasVentaBL _propuestaVentaBL { get; set; }

        public PropuestaVentaController(IPropuestasVentaBL propuestaVentaBL)
        {
            _propuestaVentaBL = propuestaVentaBL;
        }

        // GET: <PropuestaVentaController>
        [HttpGet]
        public IEnumerable<PropuestaVentaDTO> Get()
        {
            return _propuestaVentaBL.Read();
        }

        // GET <PropuestaVentaController>/5
        [HttpGet("{id}")]
        public PropuestaVentaAmpliadoDTO Get(int id)
        {
            return _propuestaVentaBL.Read(id);
        }
    }
}
