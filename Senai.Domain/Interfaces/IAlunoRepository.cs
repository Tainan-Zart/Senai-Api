using Senai.Domain.Entidades;

namespace Senai.Domain.Interfaces;
public interface IAlunoRepository
{
    bool Salvar(Aluno entity);
}
