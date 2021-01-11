using LaCochera.BL.Contracts;
using LaCochera.Core.DTO;
using LaCochera.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.BL.Implementations
{
    public class MecanicosBL : IMecanicosBL
    {
        public IMecanicosRepository _mecanicosRepository { get; set; }

        public MecanicosBL(IMecanicosRepository mecanicosRepository)
        {
            _mecanicosRepository = mecanicosRepository;
        }

        public ICollection<MecanicoDTO> Read()
        {
            return _mecanicosRepository.Read();
        }

        public MecanicoDTO Read(int id)
        {
            return _mecanicosRepository.Read(id);
        }
    }
}
