using LaCochera.BL.Contracts;
using LaCochera.Core.DTO;
using LaCochera.DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.BL.Implementations
{
    public class LoginBL : ILoginBL
    {
        public ILoginRepository _loginRepository { get; set; }

        public LoginBL(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public bool Login(LoginDTO loginDTO)
        {
            return _loginRepository.Login(loginDTO);
        }

    }
}
