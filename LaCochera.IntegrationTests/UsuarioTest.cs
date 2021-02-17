using LaCochera.API;
using LaCochera.Core.DTO;
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
    public class UsuarioTest : IClassFixture<TestFixture<Startup>>
    {

        private HttpClient Client;

        public UsuarioTest(TestFixture<Startup> fixture)
        {
            Client = fixture.Client;
        }

        [Fact]
        public async Task UsuarioTest_GetLista_ReturnsEnumerableUsuario()
        {

            //Arrange
            var request = new
            {
                Url = "/Usuario",

            };

            // Act
            var response = await Client.GetAsync(request.Url);
            var value = await response.Content.ReadAsStringAsync();
            var listaUsuarios = System.Text.Json.JsonSerializer.Deserialize<List<Usuarios>>(value);


            //Assert
            response.EnsureSuccessStatusCode();
            Assert.True(listaUsuarios.Count == 41);
        }



        [Fact]
        public async Task UsuarioTest_GetUsuario_ReturnsUsuario()
        {
            //Arrange
            var usuario = new UsuarioDTO
            {
                Id = 1,
                ConcesionarioId=5,
                Login="Jose",
                Tipo ="jefe",
                Nombre ="Jose",
                Apellidos ="De la Torre",
                Dni ="44677249-T",
                Email = "pspittall0@washingtonpost.com",
                Telefono = "933-260-7969",
                Salario = 2873
            };

            var request = new
            {
                Url = "/Usuario/1",
            };

            // Act
            var response = await Client.GetAsync(request.Url);
            var value = await response.Content.ReadAsStringAsync();
            var Usuarios = JsonConvert.DeserializeObject<UsuarioDTO>(value);


            //Assert
            response.EnsureSuccessStatusCode();
            Assert.True(usuario == Usuarios);
        }
    }
}
