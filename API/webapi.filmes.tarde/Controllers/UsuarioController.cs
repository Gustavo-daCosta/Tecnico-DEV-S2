using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Login(string email, string senha)
        {
            try
            {
                UsuarioDomain usuario = _usuarioRepository.Login(email, senha);

                return usuario == null ? NotFound("O e-mail passado não corresponde a nenhum usuário") : Ok(usuario);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }
    }
}
