using Senai.Domain.Dtos;
using Senai.Domain.Entidades;

namespace Senai.Service.Interfaces;
public interface IAlunoService
{
    bool Salvar(AlunoDto model);

    bool Remover(long id);

    Aluno? BuscarPorId(long id);

    List<Aluno> BuscarTodos();
}
