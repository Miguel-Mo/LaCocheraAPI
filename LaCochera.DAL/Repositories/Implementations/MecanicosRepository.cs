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

        public MecanicosRepository(CocherabbddContext context)
        {
            _context = context;
        }

        public ICollection<MecanicoDTO> read()
        {
            var mecanicos =  _context.Mecanicos.ToList();

            var mecanicosDTO = new List<MecanicoDTO>();

            mecanicos.ForEach(mecanico => mecanicosDTO.Add(map(mecanico)));

            return mecanicosDTO;
        }

        public MecanicoDTO read(int id)
        {
            Mecanicos mecanico = _context.Mecanicos.Find(mecanico => mecanico.Id == id);

            return map(mecanico);
        }
    }
}
