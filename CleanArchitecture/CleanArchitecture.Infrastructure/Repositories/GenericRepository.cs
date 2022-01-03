using CleanArchitecture.Infrastructure.Extentions;
using CleanArchitecture.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        internal DbContext _context;
        internal DbSet<TEntity> _dbSet;

        public GenericRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public async Task<IPaginate<TEntity>> Get(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null,
            bool enableTracking = true, int offset = 0, int limit = -1, bool isSplitQuery = false, string sql = null, params object[] parameters)
        {
            IQueryable<TEntity> query = _dbSet;

            if (!string.IsNullOrEmpty(sql)) query = _dbSet.FromSqlRaw(sql, parameters);

            if (filter != null)
                query = query.Where(filter);

            if (include != null) query = include(query);

            if (!enableTracking) query = query.AsNoTracking();

            if (orderBy != null)
                return await orderBy(query).ToPaginate(offset, limit);

            if (isSplitQuery)
                return await query.AsSplitQuery().ToPaginate(offset, limit);

            return await query.ToPaginate(offset, limit);
        }

        public async Task<IPaginate<TType>> Get<TType>(Expression<Func<TEntity, TType>> select, Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null,
            bool enableTracking = true, int offset = 0, int limit = -1, bool isSplitQuery = false, string sql = null, params object[] parameters) where TType : class
        {
            IQueryable<TEntity> query = _dbSet;

            if (!string.IsNullOrEmpty(sql)) query = _dbSet.FromSqlRaw(sql, parameters);

            if (filter != null)
                query = query.Where(filter);

            if (include != null) query = include(query);

            if (!enableTracking) query = query.AsNoTracking();

            if (orderBy != null)
                return await orderBy(query).ToPaginate(offset, limit, select);

            if (isSplitQuery)
                return await query.AsSplitQuery().ToPaginate(offset, limit, select);

            return await query.ToPaginate(offset, limit, select);
        }

        public async Task<TEntity> FirstOrDefault(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null,
            bool enableTracking = true, bool isSplitQuery = false, string sql = null, params object[] parameters)
        {
            IQueryable<TEntity> query = _dbSet;

            if (!string.IsNullOrEmpty(sql)) query = _dbSet.FromSqlRaw(sql, parameters);

            if (filter != null)
                query = query.Where(filter);

            if (include != null) query = include(query);

            if (!enableTracking) query = query.AsNoTracking();

            if (orderBy != null)
                return await orderBy(query).FirstOrDefaultAsync();

            if (isSplitQuery)
                return await query.AsSplitQuery().FirstOrDefaultAsync();

            return await query.FirstOrDefaultAsync();
        }

        public async Task<TEntity> LastOrDefault(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null,
            bool enableTracking = true, bool isSplitQuery = false, string sql = null, params object[] parameters)
        {
            IQueryable<TEntity> query = _dbSet;

            if (!string.IsNullOrEmpty(sql)) query = _dbSet.FromSqlRaw(sql, parameters);

            if (!enableTracking) query = query.AsNoTracking();

            if (filter != null)
                query = query.Where(filter);

            if (include != null) query = include(query);

            if (!enableTracking) query = query.AsNoTracking();

            if (orderBy != null)
                return await orderBy(query).LastOrDefaultAsync();

            if (isSplitQuery)
                return await query.AsSplitQuery().LastOrDefaultAsync();

            return await query.LastOrDefaultAsync();
        }

        public async ValueTask<EntityEntry<TEntity>> Insert(TEntity entity)
        {
            return await _dbSet.AddAsync(entity);
        }

        public async Task Delete(object id)
        {
            TEntity entityToDelete = _dbSet.Find(id);
            await Delete(entityToDelete);
        }

        public async Task Delete(TEntity entityToDelete)
        {
            if (_context.Entry(entityToDelete).State == EntityState.Detached)
                _dbSet.Attach(entityToDelete);
            _dbSet.Remove(entityToDelete);
        }

        public async Task Update(TEntity entityToUpdate)
        {
            _dbSet.Attach(entityToUpdate);
            _context.Entry(entityToUpdate).State = EntityState.Modified;
        }

        public async Task InsertRangeAsync(IEnumerable<TEntity> entity)
        {
            await _dbSet.AddRangeAsync(entity);
        }
    }
}
