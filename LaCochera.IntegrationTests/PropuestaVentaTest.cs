using LaCochera.API;
using LaCochera.Core.DTO;
using LaCochera.Core.DTO.Clientes;
using LaCochera.Core.DTO.Ventas;
using LaCochera.DAL.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
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
            Assert.True(listaPropuestas.Count == 30);
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
                },
                VehiculoVender = null,
                Vendedor = null
            };

            var request = new
            {
                Url = "/PropuestaVenta/5"
            };

            // Act
            var response = await Client.GetAsync(request.Url);
            var value = await response.Content.ReadAsStringAsync();
            var Propuesta = JsonConvert.DeserializeObject<PropuestaVentaAmpliadoDTO>(value);


            //Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(propuesta, Propuesta);
        }
    }
}
