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
    public class UsuarioController : ControllerBase
    {

        public IUsuarioBL _usuarioBL { get; set; }

        public UsuarioController(IUsuarioBL usuarioBL)
        {
            _usuarioBL = usuarioBL;
        }

        // GET: <PropuestaVentaController>
        [HttpGet]
        public IEnumerable<UsuarioDTO> Get()
        {
            return _usuarioBL.Read();
        }

        // GET <PropuestaVentaController>/5
        [HttpGet("{id}")]
        public UsuarioDTO Get(int id)
        {
            return _usuarioBL.Read(id);
        }
    }
}
