﻿using Senai.Domain.Entidades;
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
}