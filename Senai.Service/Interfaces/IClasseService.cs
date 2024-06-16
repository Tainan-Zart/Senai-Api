using Senai.Domain.Dtos;
using Senai.Domain.Entidades;

namespace Senai.Service.Interfaces;
public interface IClasseService
{
    bool Salvar(ClasseDto model);

    bool Remove(long id);
    Classe? BuscarPorId(long id);
    List<Classe> BuscarTodos();
}
