using Senai.Domain.Entidades;
using Senai.Domain.Interfaces;
using Senai.Repository.Context;

namespace Senai.Repository.Repository
{
    public class ProfessorRepository : IProfessorRepository
    {
        public readonly SenaiContext _context;

        public ProfessorRepository(SenaiContext context)
        {
            _context = context;
        }

        public bool Salvar(Professor entity)
        {
            try
            {
                _context.Professor.Add(entity);
                _context.SaveChanges();
                return true;

            }catch (Exception ex)
            {
                return false;
            }
           
        }

        public bool Excluir(long id )
        {
            var professor = BuscarPorId(id);
            try
            {
                _context.Professor.Remove(professor);
                _context.SaveChanges();
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public Professor? BuscarPorId(long id)
        {
            return _context.Professor.FirstOrDefault(e => e.Id == id);
        }

        public IQueryable<Professor> BuscarTodos()
        {
            return _context.Professor;
        }

    }
}
