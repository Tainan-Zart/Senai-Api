using Senai.Domain.Entidades;
using Senai.Domain.Interfaces;
using Senai.Repository.Context;

namespace Senai.Repository.Repositories;
public class AlunoRepository : IAlunoRepository
{
    public readonly SenaiContext _context;

    public AlunoRepository(SenaiContext context)
    {
        _context = context;
    }

    public bool Salvar(Aluno entity)
    {
        try
        {
            _context.Aluno.Add(entity);
            _context.SaveChanges();
            return true;
        } catch (Exception ex)
        {
            return false;
        }
    }

    public bool Remover(long id)
    {
        try
        {
            var aluno = BuscarPorId(id);
            if (aluno != null)
            {
                _context.Remove(aluno);
                _context.SaveChanges();
            }
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

        
    public Aluno? BuscarPorId(long id) {

            return _context.Aluno.FirstOrDefault(e => e.Id == id);
    }

    public IQueryable<Aluno> BuscarTodos()
    {
        return _context.Aluno;
    }

    

    }

