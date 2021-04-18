using Api.App.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace Api.App.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AuthController : Controller
    {
        private IConfiguration _config;
        public AuthController(IConfiguration Configuration)
        {
            _config = Configuration;
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login([FromBody] TokenLoginViewModel login)
        {
            bool resultado = ValidarUsuario(login);
            if (resultado)
            {
                var tokenString = GerarToken();
                return Ok(new TokenRetornoViewModel { Token = tokenString, DataTokenGerado = DateTime.Now });
            }
            else
            {
                return Unauthorized();
            }
        }

        private bool ValidarUsuario(TokenLoginViewModel login)
        {
            if (login.Usuario == "project" && login.Senha == "api#21@")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string GerarToken()
        {
            var issuer = _config["Jwt:Issuer"];
            var audience = _config["Jwt:Audience"];
            var expiry = DateTime.Now.AddMinutes(120);
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: issuer,
                audience: audience,
                expires: expiry,
                signingCredentials: credentials
                );

            var tokenHandler = new JwtSecurityTokenHandler();
            var stringToken = tokenHandler.WriteToken(token);
            return stringToken;
        }
    }
}
