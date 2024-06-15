
using Senai.Domain.Entidades;
using Senai.Domain.Interfaces;
using Senai.Repository.Context;

namespace Senai.Repository.Repositories;
public class NotaRepository : INotaRepository
{
    public readonly SenaiContext _context;

    public NotaRepository(SenaiContext context)
    {
        _context = context;
    }

    public bool Salvar(Nota entity)
    {
        _context.Nota.Add(entity);
        _context.SaveChanges();
        return true;
    }

    public IQueryable<Nota> BuscarTodos() {
    
        return _context.Nota;
    
    }
}
