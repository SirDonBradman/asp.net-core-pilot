using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Data{
    public interface IGenericRepository<T> where T : class {
        
        IQueryable<T> GetAll();
        Task<T> Get(string id);
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
        Task SaveChangesAsync();
    }
}