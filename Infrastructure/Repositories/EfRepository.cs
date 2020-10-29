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
    }
}