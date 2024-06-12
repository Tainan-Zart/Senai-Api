using Senai.Domain.Dtos;

namespace Senai.Service.Interfaces;
public interface IClasseService
{
    bool Salvar(ClasseDto model);

    bool Remove(long id);
}
