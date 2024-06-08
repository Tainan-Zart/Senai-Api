using Senai.Domain.Entidades;
using Senai.Domain.Interfaces;
using Senai.Repository.Context;
using System.Linq.Expressions;

namespace Senai.Repository.Repository
{
    public class EscolaRepository : IEscolaRepository
    {
        public readonly SenaiContext _context;

        public EscolaRepository(SenaiContext context)
        {
            _context = context;
        }

       
        public bool Salvar(Escola entity)
        {
            try
            {
                if(entity.Id == 0)
                {
                    _context.Escola.Add(entity);
                }
                else {
                    _context.Escola.Update(entity);
                }

                _context.SaveChanges();
                return true;
            }

            catch(Exception ex)
            {
                return false;
            }
          
        }

        public Escola? BuscarPorId(long id)
        {
            return _context.Escola.FirstOrDefault(e => e.Id == id);
        }

        public bool Remover(long id)
        {
            try
            {
                var escola = BuscarPorId(id);
                if (escola != null)
                {
                    _context.Escola.Remove(escola);
                    _context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IQueryable<Escola> BuscarTodos()
        {
            return _context.Escola;
        }
       


    }
        
        
}

