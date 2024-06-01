using Senai.Domain.Entidades;
using Senai.Domain.NovaPasta1;

namespace Senai.Service.Interfaces
{
    public interface IEscolaService
    {
        bool Adicionar(EscolaDto model);

        bool Remover(long id);

        Escola? BuscarPorId(long id);


    }
}
