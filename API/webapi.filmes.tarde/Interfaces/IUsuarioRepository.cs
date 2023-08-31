using webapi.filmes.tarde.Domains;

namespace webapi.filmes.tarde.Interfaces
{
    public interface IUsuarioRepository
    {
        /// <summary>
        /// Interface do Método para fazer login de um Usuário
        /// </summary>
        /// <param name="email">E-mail do usuário a ser logado</param>
        /// <param name="password">Senha do usuário a ser logado</param>
        public UsuarioDomain Login(string email, string password);
    }
}
