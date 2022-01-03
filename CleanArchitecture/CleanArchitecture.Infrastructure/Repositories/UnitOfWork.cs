using CleanArchitecture.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class UnitOfWork<TContext> : IUnitOfWork<TContext>
        where TContext : DbContext
    {
        private Dictionary<(Type type, string name), object> _repositories;

        private readonly TContext _context;

        public UnitOfWork(TContext context)
        {
            _context = context;
        }

        private bool _disposed = false;
        public async Task<bool> Commit()
        {
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        internal object GetOrAddRepository(Type type, object repo)
        {
            if (_repositories == null) _repositories = new Dictionary<(Type type, string Name), object>();

            if (_repositories.TryGetValue((type, repo.GetType().FullName), out var repository)) return repository;
            _repositories.Add((type, repo.GetType().FullName), repo);
            return repo;
        }

        public GenericRepository<TEntity> Repository<TEntity>() where TEntity : class
        {
            return (GenericRepository<TEntity>)GetOrAddRepository(typeof(TEntity), new GenericRepository<TEntity>(_context));
        }
    }
}
