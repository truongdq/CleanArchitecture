using CleanArchitecture.Infrastructure.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class Paginate<T> : IPaginate<T>
    {
        public int Count { get; set; }

        public IList<T> Items { get; set; }

        internal Paginate(IQueryable<T> source, int offset, int limit)
        {
            Count = source.Count();

            if (limit == -1)
            {
                Items = source.ToList();
            }
            else
            {
                Items = source.Skip(offset).Take(limit).ToList();
            }
        }

        internal Paginate()
        {
            Items = new T[0];
        }
    }
}
