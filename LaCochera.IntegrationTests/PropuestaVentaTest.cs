using LaCochera.API;
using LaCochera.Core.DTO;
using LaCochera.Core.DTO.Clientes;
using LaCochera.Core.DTO.Usuarios;
using LaCochera.Core.DTO.Vehiculos;
using LaCochera.Core.DTO.Ventas;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace LaCochera.IntegrationTests
{
    public class PropuestaVentaTest : IClassFixture<TestFixture<Startup>>
    {
        private HttpClient Client;

        public PropuestaVentaTest(TestFixture<Startup> fixture)
        {
            Client = fixture.Client;
        }

        [Fact]
        public async Task PropuestaVentaTest_GetLista_ReturnsEnumerablePropuestaVenta()
        {
            //Arrange
            var request = new
            {
                Url = "/PropuestaVenta"
            };

            // Act
            var response = await Client.GetAsync(request.Url);
            var value = await response.Content.ReadAsStringAsync();
            var listaPropuestas = JsonConvert.DeserializeObject<List<PropuestaVentaDTO>>(value);


            //Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(30, listaPropuestas.Count);
        }


        [Fact]
        public async Task PropuestaVentaTest_GetPropuestVenta_ReturnsPropuestaVenta()
        {
            //Arrange
            var propuesta = new PropuestaVentaAmpliadoDTO
            {
                Id = 5,
                Estado = "pendiente",
                FechaInicio = DateTime.Parse("2020-11-26 08:17:37"),
                FechaFin = null,
                FechaLimite = DateTime.Parse("2020-11-28"),
                Presupuesto = 20000,
                Cliente = new ClienteDTO {
                    Apellidos = "Gleeton",
                    DescripcionVehiculo = null,
                    Dni = "65176089-A",
                    Email = "cgleeton2@w3.org",
                    FechaRegistro = DateTime.Parse("2020-11-04 22:49:12"),
                    Id = 3,
                    Nombre = "Cesar",
                    Presupuesto = 112,
                    Telefono = "317 496 1767",
                },
                VehiculoVender = new VehiculoVenderDTO { 
                    Combustible = null,
                    Id = 23,
                    Imagen = "Sin imagen",
                    KmRecorridos = 0,
                    Precio = 12050.88M,
                    SegundaMano = false,
                    TiempoUsado = null,
                    Vendido = false,
                    Vehiculo = new VehiculoDTO 
                    {
                        Id = 23,
                        Marca = "Mercedes-Benz",
                        Modelo = "E-Class",
                        FechaRegistro = DateTime.Parse("2020-06-08 10:02:07"),
                        Potencia = "70-cv",
                        Concesionario = new ConcesionarioDTO 
                        {
                            Id = 5,
                            Ciudad = "Hot Springs National Park",
                            Cp = "71914",
                            Direccion = "19 American Park",
                            Provincia = "Arkansas",
                        },
                        Tipo = new TipoVehiculoDTO
                        {
                            Id = 1,
                            Descripcion = "Coche",
                        },
                    },
                },
                Vendedor = new VendedorDTO
                {
                    Id = 1,
                    NumVentas = 40,
                    Usuario = new UsuarioNombreDTO
                    {
                        Nombre= "Jose",
                        Apellidos= "De la Torre",
                    },
                }
            };

            var request = new
            {
                Url = "/PropuestaVenta/5"
            };

            // Act
            var response = await Client.GetAsync(request.Url);
            var value = await response.Content.ReadAsStringAsync();
            var respuestaPropuesta = JsonConvert.DeserializeObject<PropuestaVentaAmpliadoDTO>(value);


            //Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(respuestaPropuesta, propuesta);
        }
    }
}
