using LaCochera.BL.Contracts;
using LaCochera.Core.DTO;
using LaCochera.DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.BL.Implementations
{
    public class PropuestasVentaBL : IPropuestasVentaBL
    {
        public IPropuestaVentaRepository _propuestasVentaRepository { get; set; }

        public PropuestasVentaBL(IPropuestaVentaRepository propuestasVentaRepository)
        {
            _propuestasVentaRepository = propuestasVentaRepository;
        }

        public ICollection<PropuestaVentaDTO> Read()
        {
            return _propuestasVentaRepository.Read();
        }

        public PropuestaVentaDTO Read(int id)
        {
            return _propuestasVentaRepository.Read(id);
        }
    }
}
