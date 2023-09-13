using Microsoft.EntityFrameworkCore;
using webapi.inlock.tarde.Contexts;
using webapi.inlock.tarde.Domains;
using webapi.inlock.tarde.Interfaces;

namespace webapi.inlock.tarde.Repositories
{
    public class EstudioRepository : IEstudioRepository
    {
        InLockContext ctx = new InLockContext();

        public void Atualizar(Guid id, Estudio estudio)
        {
            Estudio estudioBuscado = BuscarPorId(id);

            if (estudioBuscado != null)
            {
                estudioBuscado.Nome = estudio.Nome;
            }
            ctx.Estudios.Update(estudioBuscado!);
            ctx.SaveChanges();
        }

        public Estudio BuscarPorId(Guid id) => ListarComJogos().FirstOrDefault(estudio => estudio.IdEstudio == id)!;

        public void Cadastrar(Estudio estudio)
        {
            ctx.Estudios.Add(estudio);
            ctx.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Estudio estudioBuscado = BuscarPorId(id)!;

            if (estudioBuscado != null)
            {
                ctx.Estudios.Remove(estudioBuscado);
                ctx.SaveChanges();
            }
        }

        public List<Estudio> Listar() => ctx.Estudios.ToList();

        public List<Estudio> ListarComJogos() => ctx.Estudios.Include(estudio => estudio.Jogos).ToList();
    }
}
