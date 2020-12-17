using LaCochera.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.DAL.Repositories.Contracts
{
    public interface ILoginRepository
    {
        bool Login(LoginDTO loginDTO);
    }
}
