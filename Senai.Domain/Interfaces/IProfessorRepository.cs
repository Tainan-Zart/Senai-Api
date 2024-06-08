using Senai.Domain.Entidades;

namespace Senai.Domain.Interfaces
{
    public interface  IProfessorRepository
    {
        bool Salvar(Professor entity);
        bool Excluir(long id);
        Professor? BuscarPorId(long id);

        IQueryable<Professor> BuscarTodos();
    }
}
