using System;
using System.Collections.Generic;
using MediatRDemo.Data.Database;
using Microsoft.EntityFrameworkCore;

namespace MediatRDemo.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private ApiDbContext _context = null;
        private DbSet<T> table = null;
        public Repository()
        {
            this._context = new ApiDbContext();
            table = _context.Set<T>();
        }
        public Repository(ApiDbContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }
        public T GetById(object id)
        {
            return table.Find(id);
        }
        public void Insert(T obj)
        {
            table.Add(obj);
        }
        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

