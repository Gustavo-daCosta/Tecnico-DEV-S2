using Microsoft.AspNetCore.Mvc;
using webapi.inlock.codefirst.Domains;
using webapi.inlock.codefirst.Interfaces;
using webapi.inlock.codefirst.Repositories;

namespace webapi.inlock.codefirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        [Route("Cadastrar")]
        public IActionResult Post(Usuario usuario)
        {
            try
            {
                _usuarioRepository.Cadastrar(usuario);

                return Ok(201);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        // falta implementar o endpoint
        [HttpGet]
        [Route("Deletar")]
        public IActionResult GetUser(Usuario usuario)
        {
            try
            {
                _usuarioRepository.BuscarUsuario(usuario.Email, usuario.Senha);
                return Ok(usuario);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }
    }
}
