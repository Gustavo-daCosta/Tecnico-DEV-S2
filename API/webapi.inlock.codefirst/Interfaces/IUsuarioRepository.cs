using webapi.inlock.codefirst.Domains;

namespace webapi.inlock.codefirst.Interfaces
{
    public interface IUsuarioRepository
    {
        public Usuario BuscarUsuario(string email, string senha);

        public void Cadastrar(Usuario usuario);
    }
}
