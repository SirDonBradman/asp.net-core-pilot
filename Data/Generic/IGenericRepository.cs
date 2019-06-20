using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Data{
    public interface IGenericRepository<T> where T : class {
        
        Task<ICollection<T>> GetAll();
        Task<T> Get(string id);
        ICollection<T> FindBy(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
        Task SaveChangesAsync();
    }
}