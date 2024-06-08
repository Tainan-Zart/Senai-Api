using Senai.Domain.Entidades;

namespace Senai.Domain.Interfaces
{
    public interface IEscolaRepository
    {
        bool Salvar(Escola entity);

        bool Remover(long id);

        Escola? BuscarPorId(long id);

        IQueryable<Escola> BuscarTodos();

    }
}
