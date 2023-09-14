using Microsoft.Extensions.Diagnostics.HealthChecks;
using webapi.inlock.codefirst.Domains;

namespace webapi.inlock.codefirst.Interfaces
{
    public interface IEstudioRepository
    {
        public List<Estudio> Listar();

        public Estudio BuscarPorId(Guid id);

        public void Cadastrar(Estudio estudio);

        public void Atualizar(Guid id, Estudio estudio);

        public void Deletar(Guid id);
    }
}
