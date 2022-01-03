using CleanArchitecture.Infrastructure.Interfaces;
using CleanArchitecture.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Extentions
{
    public static class PaginateExtension
    {
        public static async Task<IPaginate<T>> ToPaginate<T>(this IQueryable<T> source, int offset, int limit)
        {
            var count = await source.CountAsync().ConfigureAwait(false);
            var items = await ((limit == -1) ? source.ToListAsync().ConfigureAwait(false) : source.Skip(offset).Take(limit).ToListAsync().ConfigureAwait(false));
            return new Paginate<T>
            {
                Count = count,
                Items = items
            };
        }

        public static async Task<IPaginate<TType>> ToPaginate<T, TType>(this IQueryable<T> source, int offset, int limit, Expression<Func<T, TType>> select) where TType : class
        {
            var count = await source.CountAsync().ConfigureAwait(false);
            var items = await ((limit == -1) ? source.Select(select).ToListAsync().ConfigureAwait(false) : source.Skip(offset).Take(limit).Select(select).ToListAsync().ConfigureAwait(false));
            return new Paginate<TType>
            {
                Count = count,
                Items = items
            };
        }
    }
}
