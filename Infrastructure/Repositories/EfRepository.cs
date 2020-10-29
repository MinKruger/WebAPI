using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI.Core.Entities;
using WebAPI.Core.Repositories;

namespace WebAPI.Infrastructure.Repositories
{
    public class EfRepository<T> : IAsyncRepository<T> where T : EntityBase
    {
        private DbContext _dataContext;

        public EfRepository(DbContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task Add(T entity)
        {
            _dataContext.Set<T>().Add(entity);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dataContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _dataContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Remove(T entity)
        {
            _dataContext.Set<T>().Remove(entity);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            _dataContext.Entry(entity).State = EntityState.Modified;
            await _dataContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> FindBy(params Expression<Func<T, object>>[] includes)
        {
            var query = _dataContext.Set<T>().AsNoTracking();
            return await includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty)).ToListAsync();
        }

        public async Task<IEnumerable<T>> FindBy(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            var query = _dataContext.Set<T>().AsNoTracking().Where(predicate);
            return await includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty)).ToListAsync();
        }

        public async Task<IEnumerable<T>> FindBy(Expression<Func<T, bool>> predicate)
        {
            return await _dataContext.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task<IEnumerable<T>> FindByExpression(Expression<Func<T, bool>> filter = null,
                                                    params Expression<Func<T, object>>[] orders)
        {
            var query = filter == null? _dataContext.Set<T>().OrderBy(m => true) : _dataContext.Set<T>().Where(filter).OrderBy(m => true);
            query = orders.Aggregate(query, (current, order) => current.ThenBy(order));

            return await query.ToListAsync();
        }
    }
}