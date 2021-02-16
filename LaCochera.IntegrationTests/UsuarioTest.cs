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
            var listaUsuarios = JsonSerializer.Deserialize<List<Usuarios>>(value);


            //Assert
            response.EnsureSuccessStatusCode();
            Assert.True(listaUsuarios.Count == 41);
        }


        [Fact]
        public async Task UsuarioTest_GetUsuario_ReturnsUsuario()
        {
            //Arrange
            Usuarios usuario = new Usuarios
            {
                Id = 1,
                ConcesionarioId=5,
                Login="Jose",
                Password= "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4",
                Tipo ="jefe",
                Nombre ="Jose",
                Apellidos ="De la Torre",
                Dni ="44677249-T",
                Email =" pspittall0@washingtonpost.com",
                Telefono = "933-260-7969",
                Salario = 2873

            };

            var request = new
            {
                Url = "/Usuarios/1",

            };

            // Act
            var response = await Client.GetAsync(request.Url);
            var value = await response.Content.ReadAsStringAsync();
            var Usuarios = JsonSerializer.Deserialize<Usuarios>(value);



            //Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(usuario, Usuarios);
        }





    }
}
