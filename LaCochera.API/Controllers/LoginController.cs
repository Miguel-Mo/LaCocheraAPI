using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaCochera.Core.DTO;
using LaCochera.BL.Contracts;

namespace LaCochera.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public ILoginBL _LoginBL { get; set; }

        public LoginController(ILoginBL loginBL)
        {
            _LoginBL = loginBL;
        }

        /// <summary>
        /// Método que permite el acceso al panel de administración
        /// </summary>
        /// /// <remarks>
        /// Ejemplo de JSON a enviar:
        ///
        ///     POST /login
        ///     {
        ///        "usuario": "jose",
        ///        "password": "1234"
        ///     }
        ///
        /// </remarks>
        /// <returns>
        /// True o false según si el login ha sido exitoso o no
        /// </returns>
        /// <response code="200">Si el usuario y contraseña facilitados pertencen a un usuario jefe y, por tanto,
        /// tiene permisos de acceso al panel de administración devuelve true, false lo opuesto</response>
        /// <param name="loginDTO">
        /// Usuario y contraseña con el que se pretende acceder al panel admin
        /// </param>  
        [HttpPost]
        public bool Logining(LoginDTO loginDTO)
        {
            return _LoginBL.Login(loginDTO);
        }

    }
}
