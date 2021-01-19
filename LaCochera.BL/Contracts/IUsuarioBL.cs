using LaCochera.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.BL.Contracts
{
    public interface IUsuarioBL
    {
        ICollection<UsuarioDTO> Read();
        UsuarioDTO Read(int id);
    }
}
