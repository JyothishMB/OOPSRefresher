using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDemo.Infrastructure.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetAsync(int id);
        List<T> GetAll();
        T Create(T entity);
        void Remove(int id);
    }
}
