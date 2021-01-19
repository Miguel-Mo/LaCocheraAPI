using LaCochera.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.DAL.Repositories.Contracts
{
    public interface IUsuarioRepository
    {
        ICollection<UsuarioDTO> Read();
        UsuarioDTO Read(int id);
    }
}
