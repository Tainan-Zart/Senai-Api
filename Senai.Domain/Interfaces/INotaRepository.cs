using Senai.Domain.Entidades;

namespace Senai.Domain.Interfaces;
public interface INotaRepository
{
    bool Salvar(Nota entity);

    IQueryable<Nota> BuscarTodos();
}
