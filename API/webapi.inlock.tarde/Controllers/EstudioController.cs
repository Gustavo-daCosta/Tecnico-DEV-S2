using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.inlock.tarde.Domains;
using webapi.inlock.tarde.Interfaces;
using webapi.inlock.tarde.Repositories;

namespace webapi.inlock.tarde.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class EstudioController : ControllerBase
    {
        private IEstudioRepository _estudioRepository = new EstudioRepository();

        [HttpGet]
        [Route("ListarTodos")]
        public IActionResult Get()
        {
            try
            {
                return Ok(_estudioRepository.Listar());
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpGet]
        [Route("ListarComJogos")]
        public IActionResult GetWithGames()
        {
            try
            {
                return Ok(_estudioRepository.ListarComJogos());
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpDelete]
        [Route("Deletar")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _estudioRepository.Deletar(id);

                return NoContent();
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpPost]
        [Route("Cadastrar")]
        public IActionResult Post(Estudio estudio)
        {
            try
            {
                _estudioRepository.Cadastrar(estudio);

                return StatusCode(201);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpGet]
        [Route("BuscarPorId")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                return Ok(_estudioRepository.BuscarPorId(id));
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpPut]
        [Route("Atualizar")]
        public IActionResult Put(Guid id, Estudio estudio)
        {
            try
            {
                _estudioRepository.Atualizar(id, estudio);

                return StatusCode(201);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }
    }
}
