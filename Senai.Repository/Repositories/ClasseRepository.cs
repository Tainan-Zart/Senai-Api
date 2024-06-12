using Senai.Domain.Entidades;
using Senai.Domain.Interfaces;
using Senai.Repository.Context;

namespace Senai.Repository.Repositories;
public class ClasseRepository : IClasseRepository
{
    public readonly SenaiContext _context;

    public ClasseRepository(SenaiContext context)
    {
        _context = context;
    }

    public bool Salvar(Classe entity)
    {
        try
        {
            _context.Classe.Add(entity);
            _context.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public bool Delete(long id)
    {

        try
        {
            var classe = BuscarPorId(id);
            _context.Classe.Remove(classe);
            _context.SaveChanges();
            return true;
        }

        catch
        {
            return false;
        }
    }

    public Classe? BuscarPorId(long id) 
    { 
        return _context.Classe.FirstOrDefault(c => c.Id == id);
    }
    

}
