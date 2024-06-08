using Senai.Domain.Entidades;
using Senai.Domain.NovaPasta1;

namespace Senai.Service.Interfaces
{
    public interface  IProfessorService
    {
        bool Salvar(ProfessorDto model);

        bool Excluir(long id);

        Professor? BuscarPorId(long id);

        List<Professor> BuscarTodos();
    }
}
