using Senai.Domain.Entidades;
using Senai.Domain.Interfaces;
using Senai.Repository.Context;
using System.Linq.Expressions;

namespace Senai.Repository.Repositories
{
    public class EscolaRepository : IEscolaRepository
    {
        public readonly SenaiContext _context;

        public EscolaRepository(SenaiContext context)
        {
            _context = context;
        }

       
        public bool Adicionar(Escola entity)
        {
            try
            {
                _context.Escola.Add(entity);
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

       


    }
        
        
}

