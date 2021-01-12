using LaCochera.Core.DTO;
using LaCochera.DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using LaCochera.DAL.Models;
using System.Linq;
using System.Security.Cryptography;

namespace LaCochera.DAL.Repositories.Implementations
{
    public class LoginRepository : ILoginRepository
    {
        public CocherabbddContext _context { get; set; }

        public LoginRepository(CocherabbddContext context)
        {
            _context = context;
        }


        public bool Login(LoginDTO loginDTO)
        {
            string prueba = ToSHA256(loginDTO.Password);
            return _context.Usuarios.Any(u => u.Login == loginDTO.Usuario && u.Password == ToSHA256(loginDTO.Password));
        }

        private string ToSHA256(string pass)
        {
            byte[] sha256 = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(pass));

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < sha256.Length; i++)
                builder.Append(sha256[i].ToString("x2"));
            return builder.ToString();
        }
    }
}
