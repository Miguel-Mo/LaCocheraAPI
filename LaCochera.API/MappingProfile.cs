using AutoMapper;
using LaCochera.Core.DTO;
using LaCochera.Core.DTO.Usuarios;
using LaCochera.Core.DTO.Vehiculos;
using LaCochera.DAL.Models;

namespace LaCochera.API
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Usuarios
            CreateMap<Usuarios, UsuarioDTO>();
            CreateMap<Mecanicos, MecanicoDTO>();
            CreateMap<Vendedores, VendedorDTO>();
            CreateMap<Jefe, JefeDTO>();
            CreateMap<Especialidades, EspecialidadDTO>();

            // Vehículos
            CreateMap<Vehiculos, VehiculoDTO>();
            CreateMap<VehiculosVender, VehiculoVenderDTO>();
            CreateMap<VehiculosReparar, VehiculoRepararDTO>();
            CreateMap<TiposVehiculos, TipoVehiculoDTO>();
            CreateMap<CombustibleVehiculos, CombustibleDTO>();

            // Root
            CreateMap<Cliente, ClienteDTO>();
            CreateMap<Concesionarios, ConcesionarioDTO>();
            CreateMap<PropuestaVenta, PropuestaVentaDTO>();
            CreateMap<Reparaciones, ReparacionDTO>();
        }
    }
}