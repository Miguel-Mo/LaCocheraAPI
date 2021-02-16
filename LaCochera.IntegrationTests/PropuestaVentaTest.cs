using LaCochera.API;
using LaCochera.DAL.Models;
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
                Url = "/PropuestaVenta",

            };

            // Act
            var response = await Client.GetAsync(request.Url);
            var value = await response.Content.ReadAsStringAsync();
            var listaPropuestas = JsonSerializer.Deserialize<List<PropuestaVenta>>(value);


            //Assert
            response.EnsureSuccessStatusCode();
            Assert.True(listaPropuestas.Count == 30);


        }


        [Fact]
        public async Task PropuestaVentaTest_GetPropuestVenta_ReturnsPropuestaVenta()
        {

            //Arrange
            PropuestaVenta propuesta = new PropuestaVenta
            {
                Id = 5,
                ClienteId = 3,
                VendedorId = 1,
                VehiculoVenderId = 23,
                Estado = "pendiente",
                FechaInicio = DateTime.Parse("2020 - 11 - 26 08:17:37"),
                FechaFin = null,
                FechaLimite = DateTime.Parse("2020-11-28"),
                Presupuesto = 20000
            };

            var request = new
            {
                Url = "/PropuestaVenta/5",

            };

            // Act
            var response = await Client.GetAsync(request.Url);
            var value = await response.Content.ReadAsStringAsync();
            var Propuesta = JsonSerializer.Deserialize<PropuestaVenta>(value);



            //Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(propuesta, Propuesta);



        }






    }
}
