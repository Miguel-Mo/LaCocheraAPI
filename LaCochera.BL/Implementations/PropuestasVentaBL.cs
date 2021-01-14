using LaCochera.BL.Contracts;
using LaCochera.Core.DTO;
using LaCochera.Core.DTO.Ventas;
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

        public ICollection<PropuestaVentaAmpliadoDTO> Read()
        {
            return _propuestasVentaRepository.Read();
        }

        public PropuestaVentaAmpliadoDTO Read(int id)
        {
            return _propuestasVentaRepository.Read(id);
        }
    }
}
