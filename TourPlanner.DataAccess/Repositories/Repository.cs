﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TourPlanner.DataAccess.Context;
using TourPlanner.DataAccess.Repositories.Interfaces;

namespace TourPlanner.DataAccess.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly TourContext _context;

    public Repository(TourContext context)
    {
        _context = context;
    }

    public T? GetById(int id)
    {
        return _context.Set<T>().Find(id);
    }

    public IEnumerable<T> GetAll()
    {
        return _context.Set<T>().ToList();
    }

    public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
    {
        return _context.Set<T>().Where(expression);
    }

    public void Add(T entity)
    {
        _context.Set<T>().Add(entity);
    }

    public void AddRange(IEnumerable<T> entities)
    {
        _context.Set<T>().AddRange(entities);
    }

    public void Remove(T entity)
    {
        _context.Set<T>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<T> entities)
    {
        _context.Set<T>().RemoveRange(entities);
    }
}