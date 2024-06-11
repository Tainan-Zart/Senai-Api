using Senai.Domain.Entidades;

namespace Senai.Domain.Interfaces;
public interface IAlunoRepository
{
    bool Salvar(Aluno entity);

    Aluno? BuscarPorId(long id);

    bool Remover(long id);
}
