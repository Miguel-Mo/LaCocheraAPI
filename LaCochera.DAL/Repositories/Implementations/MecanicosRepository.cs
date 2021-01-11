using AutoMapper;
using LaCochera.Core.DTO;
using LaCochera.DAL.Models;
using LaCochera.DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaCochera.DAL.Repositories.Implementations
{
    public class MecanicosRepository : IMecanicosRepository
    {
        public CocherabbddContext _context { get; set; }
        private IMapper _mapper;

        public MecanicosRepository(CocherabbddContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ICollection<MecanicoDTO> Read()
        {
            var mecanicos =  _context.Mecanicos.ToList();

            var mecanicosDTO = _mapper.Map<ICollection<MecanicoDTO>>(mecanicos);

            return mecanicosDTO;
        }

        public MecanicoDTO Read(int id)
        {
            Mecanicos mecanico = new Mecanicos();

            return _mapper.Map<MecanicoDTO>(mecanico);
        }
    }
}
