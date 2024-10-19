using MediatorDemo.Infrastructure.Data.Contexts;
using MediatorDemo.Infrastructure.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDemo.Infrastructure.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private MediatorDemoContext _context;

        public Repository(MediatorDemoContext context)
        {
            _context = context;
        }
        public T Create(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public async Task<T> GetAsync(int id)
        {
            var result = await _context.Set<T>().FindAsync(id);
            return result;
        }

        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList<T>();
        }

        public void Remove(int id)
        {
            var q = Get(id);
            _context.Set<T>().Remove(q);
            _context.SaveChanges();
        }
    }
}
