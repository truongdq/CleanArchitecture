using CleanArchitecture.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Interfaces
{
    public interface IUnitOfWork<TContext> : IDisposable
        where TContext : DbContext
    {
        public Task<bool> Commit();

        void Dispose();

        GenericRepository<TEntity> Repository<TEntity>() where TEntity : class;
    }
}
