using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
    [Authorize(Roles = "Administrador")]
    public class GeneroController : ControllerBase
    {
        /// <summary>
        /// Objeto que irá receber os métodos definidos na interface
        /// </summary>
        private IGeneroRepository _generoRepository { get; set; }

        /// <summary>
        /// Instância do objeto _generoRepository para que haja referência aos métodos no repositório
        /// </summary>
        public GeneroController() => _generoRepository = new GeneroRepository();

        /// <summary>
        /// Endpoint que acessa o método de listar os gêneros
        /// </summary>
        /// <returns>Lista de gêneros e um Status Code</returns>
        [HttpGet]
        [Route("ListarTodos")]
        public IActionResult GetAll()
        {
            try
            {
                List<GeneroDomain> listaGeneros = _generoRepository.ListarTodos();

                // Retorna o status code 200 ok e a lista de gêneros no formato JSON
                return StatusCode(200, listaGeneros);
                //return Ok(listaGeneros);
            }
            catch (Exception error)
            {
                // Retorna um status code 400 - BadRequest e a mensagem de erro
                return BadRequest(error.Message);
            }
        }

        /// <summary>
        /// Endpoint que acesso o método de buscar gênero a partir de um Id
        /// </summary>
        /// <returns>Gênero encontrado e um status code</returns>
        [HttpGet]
        [Route("BuscarPorId")]
        [Authorize]
        public IActionResult GetById(int id) // IActionResult - Espera que se retorne um status code
        {
            try
            {
                GeneroDomain genero = _generoRepository.BuscarPorId(id);

                return genero == null ? NotFound("O gênero buscado não foi encontrado") : StatusCode(200, genero);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Endpoint que acessa o método de cadastrar gênero
        /// </summary>
        /// <returns>Gênero a ser cadastrado e status code</returns>
        [HttpPost]
        [Route("Cadastrar")]
        [Authorize]
        public IActionResult Post(GeneroDomain novoGenero)
        {
            try
            {
                _generoRepository.Cadastrar(novoGenero);

                return Created("Objeto criado", novoGenero);
                //return StatusCode(201, novoGenero);
            } catch (Exception error)
            {
                // Retorna um status code BadRequest(400) e a mensagem de erro
                return BadRequest(error.Message);
            }
        }

        /// <summary>
        /// Endpoint que acessa o método de deletar gênero
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("Deletar/{id}")]
        [Authorize]
        //[Route("Deletar")]
        public IActionResult Delete(int id)
        {
            try
            {
                GeneroDomain genero = _generoRepository.BuscarPorId(id);

                if (genero != null)
                {
                    _generoRepository.Deletar(id);
                    return StatusCode(204, id);
                } else
                {
                    return NotFound("O gênero a ser deletado não foi encontrado.");
                }
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpPut]
        [Route("AtualizarIdCorpo")]
        [Authorize]
        public IActionResult PutIdBody(GeneroDomain genero)
        {
            try
            {
                GeneroDomain generoBuscado = _generoRepository.BuscarPorId(genero.IdGenero);

                if (generoBuscado != null)
                {
                    _generoRepository.Atualizar(genero);
                    return StatusCode(200, genero);
                }
                else
                {
                    return NotFound($"O ID {genero.IdGenero} não corresponde a nenhum gênero.");
                }
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpPut("AtualizarIdURL/{id}")]
        [Authorize]
        public IActionResult PutIdUrl(int id, GeneroDomain genero)
        {
            try
            {
                GeneroDomain generoBuscado = _generoRepository.BuscarPorId(id);

                if (generoBuscado != null)
                {
                    genero.IdGenero = id;
                    _generoRepository.Atualizar(genero);
                    return StatusCode(200, genero);
                } else
                {
                    return NotFound($"O ID {id} não corresponde a nenhum gênero.");
                }
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }
    }
}
