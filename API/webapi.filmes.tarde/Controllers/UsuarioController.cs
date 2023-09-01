using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using webapi.filmes.tarde.Domains;
using webapi.filmes.tarde.Interfaces;
using webapi.filmes.tarde.Repositories;

namespace webapi.filmes.tarde.Controllers
{
    /// <summary>
    /// Define que a rota de uma requisição será no seguinte formato
    /// dominio/api/nomeController
    /// exemplo: http://localhost:5000/api/Genero
    /// </summary>
    [Route("api/[controller]")]
    /// <summary>
    /// Define quem é o controlador da API
    /// </summary>
    [ApiController]
    /// <summary>
    /// Define o tipo de resposta da API como JSON
    /// </summary>
    [Produces("application/json")]
    public class UsuarioController : ControllerBase
    {
        /// <summary>
        /// Objeto que irá receber os métodos definidos na interface
        /// </summary>
        private IUsuarioRepository _usuarioRepository { get; set; }

        /// <summary>
        /// Instância do objeto _filmeRepository para que haja referência aos métodos no repositório
        /// </summary>
        public UsuarioController() => _usuarioRepository = new UsuarioRepository();

        [HttpGet]
        [Route("Login")]
        public IActionResult Login(UsuarioDomain usuario)
        {
            try
            {
                UsuarioDomain usuarioBuscado = _usuarioRepository.Login(usuario.Email, usuario.Senha);

                if (usuarioBuscado == null) return NotFound("Usuário não encontrado");
                if (usuarioBuscado != null) if (usuarioBuscado.Email == usuario.Email && usuarioBuscado.Senha != usuario.Senha)
                        return Conflict("Senha incorreta");


                // Caso encontre o usuário buscado, prossegue para a criação do Token

                // 1 - Definir as informações(Claims) que serão fornecidas no Token (Payload)
                var claims = new[]
                {
                    // formato da claim(tipo, valor)
                    new Claim(JwtRegisteredClaimNames.Jti, usuario.IdUsuario.ToString()),
                    new Claim(JwtRegisteredClaimNames.Email, usuario.Email),
                    new Claim(ClaimTypes.Role, usuarioBuscado.Permissao.ToString()),

                    // Existe a possibilidade de criar uma claim personalizada
                    new Claim("Claim personalizada", "Valor personalizado"),
                };

                // 2 - Definir a chave de acesso ao token
                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("filmes-chave-autenticacao-webapi-dev"));

                // 3 - Definir as credenciais do token (Header)
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                // 4 - Gerar o Token
                var token = new JwtSecurityToken
                (
                    // Emissor do Token
                    issuer: "webapi.filmes.tarde",

                    // Destinatário
                    audience: "webapi.filmes.tarde",

                    // Dados definidos nas claims (Payload)
                    claims: claims,

                    // Tempo de expiração
                    expires: DateTime.Now.AddMinutes(30),

                    // Credenciais do Token
                    signingCredentials: creds
                );

                // 5 - Retornar o token criado
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });

                //return usuario == null ? NotFound("O e-mail passado não corresponde a nenhum usuário") : Ok(usuario);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }
    }
}
