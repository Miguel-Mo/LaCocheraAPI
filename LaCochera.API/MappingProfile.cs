using AutoMapper;
using LaCochera.Core.DTO;
using LaCochera.Core.DTO.Clientes;
using LaCochera.Core.DTO.Reparaciones;
using LaCochera.Core.DTO.Usuarios;
using LaCochera.Core.DTO.Vehiculos;
using LaCochera.Core.DTO.Ventas;
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
            CreateMap<Mecanicos, MecanicoConReparacionesDTO>();
            CreateMap<Especialidades, EspecialidadDTO>();

            CreateMap<Vendedores, VendedorDTO>();
            CreateMap<Vendedores, VendedorConVentasDTO>();

            CreateMap<Jefe, JefeDTO>();

            // Vehículos
            CreateMap<Vehiculos, VehiculoDTO>();

            CreateMap<VehiculosVender, VehiculoVenderDTO>();
            CreateMap<VehiculosVender, VehiculoConVentasDTO>();

            CreateMap<VehiculosReparar, VehiculoRepararDTO>();
            CreateMap<VehiculosReparar, VehiculoConReparacionesDTO>();

            CreateMap<TiposVehiculos, TipoVehiculoDTO>();
            CreateMap<CombustibleVehiculos, CombustibleDTO>();

            // Clientes
            CreateMap<Cliente, ClienteDTO>();
            CreateMap<Cliente, ClienteAmpliadoDTO>();

            // Reparaciones
            CreateMap<Reparaciones, ReparacionAmpliadoDTO>();
            CreateMap<Reparaciones, ReparacionDTO>();

            // Ventas
            CreateMap<PropuestaVenta, PropuestaVentaAmpliadoDTO>();
            CreateMap<PropuestaVenta, PropuestaVentaDTO>();

            // Concesionario
            CreateMap<Concesionarios, ConcesionarioDTO>();
        }
    }
}