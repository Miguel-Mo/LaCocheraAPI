using LaCochera.BL.Contracts;
using LaCochera.Core.DTO;
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
        public PropuestaVentaDTO Get(int id)
        {
            return _propuestaVentaBL.Read(id);
        }

        // POST <PropuestaVentaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT <PropuestaVentaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE <PropuestaVentaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
