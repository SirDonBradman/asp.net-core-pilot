using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Core.Data {
    public abstract class GenericRepository<T> : 
        IGenericRepository<T> where T : class, new() {

        private readonly DbContext _entities;
        public GenericRepository(DbContext Context) {
            _entities = Context;
        }

        public virtual async Task<ICollection<T>> GetAll() {
            IQueryable<T> query = _entities.Set<T>();
            return await Task.Run(() => query.ToList());
        }

        public ICollection<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate) {
            IQueryable<T> query = _entities.Set<T>().Where(predicate);
            return query.ToList();
        }

        public virtual void Add(T entity) {
            _entities.Set<T>().Add(entity);
        }

        public virtual void Delete(T entity) {
            _entities.Set<T>().Remove(entity);
        }

        public virtual void Edit(T entity) {
            _entities.Entry(entity).State = EntityState.Modified;
        }

        public async virtual Task SaveChangesAsync() {
            await _entities.SaveChangesAsync();
        }

        public async Task<T> Get(string id)
        {
            return await _entities.Set<T>().FindAsync(id);
        }
    }
}