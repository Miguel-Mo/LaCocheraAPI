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
        public LoginController(ILoginBL loginBL)
        {
            _LoginBL = loginBL;
        }

        public ILoginBL _LoginBL { get; set; }

        [HttpPost]
        public bool Logining(LoginDTO loginDTO)
        {
            return _LoginBL.Login(loginDTO);
        }


    }





}
