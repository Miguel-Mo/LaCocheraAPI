using LaCochera.BL.Contracts;
using LaCochera.Core.DTO;
using LaCochera.DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.BL.Implementations
{
    public class ReparacionesBL : IReparacionesBL
    {
        public IReparacionesRepository _reparacionesRepository { get; set; }

        public ReparacionesBL(IReparacionesRepository reparacionesRepository)
        {
            _reparacionesRepository = reparacionesRepository;
        }

        public ICollection<ReparacionDTO> Read()
        {
            return _reparacionesRepository.Read();
        }

        public ReparacionDTO Read(int id)
        {
            return _reparacionesRepository.Read(id);
        }
    }
}
