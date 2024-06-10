using Senai.Domain.Dtos;

namespace Senai.Service.Interfaces;
public interface IAlunoService
{
    bool Salvar(AlunoDto model);
}
