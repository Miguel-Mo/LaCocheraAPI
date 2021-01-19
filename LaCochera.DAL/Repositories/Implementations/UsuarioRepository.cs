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
    public class UsuarioRepository : IUsuarioRepository
    {
        public CocherabbddContext _context { get; set; }
        private IMapper _mapper;

        public UsuarioRepository(CocherabbddContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ICollection<UsuarioDTO> Read()
        {
            var lista = _context.Usuarios.ToList();

            var listaDTO = _mapper.Map<ICollection<UsuarioDTO>>(lista);

            return listaDTO;
        }

        public UsuarioDTO Read(int id)
        {
            var item = _context.Usuarios.Find(id);

            return _mapper.Map<UsuarioDTO>(item);
        }
    }
}