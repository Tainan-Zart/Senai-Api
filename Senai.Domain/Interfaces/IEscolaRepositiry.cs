using Senai.Domain.Entidades;

namespace Senai.Domain.Interfaces
{
    public interface IEscolaRepository
    {
        bool Adicionar(Escola entity);

        bool Remover(long id);

        Escola BuscarPorId(long id);




    }
}
