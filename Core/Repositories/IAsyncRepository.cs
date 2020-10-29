using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebAPI.Core.Entities;

namespace WebAPI.Core.Repositories
{
    public interface IAsyncRepository<T> where T : EntityBase
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        Task Add(T entity);
        Task Update(T entity);
        Task Remove(T entity);
        Task<IEnumerable<T>> FindBy(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> FindBy(params Expression<Func<T, object>>[] includes);
        Task<IEnumerable<T>> FindBy(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);
        Task<IEnumerable<T>> FindByExpression(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] orders);

    }
}