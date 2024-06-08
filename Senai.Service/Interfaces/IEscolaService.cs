using Senai.Domain.Entidades;
using Senai.Domain.NovaPasta1;

namespace Senai.Service.Interfaces
{
    public interface IEscolaService
    {
        bool Salvar(EscolaDto model);

        bool Remover(long id);

        Escola? BuscarPorId(long id);

        List<Escola> BuscarTodos();


    }
}
