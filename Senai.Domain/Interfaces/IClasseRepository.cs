using Senai.Domain.Entidades;

namespace Senai.Domain.Interfaces;
public  interface IClasseRepository
{
    bool Salvar(Classe entity);

    Classe? BuscarPorId(long id);

    bool Delete(long id);

    IQueryable<Classe> BuscarTodos();
}
