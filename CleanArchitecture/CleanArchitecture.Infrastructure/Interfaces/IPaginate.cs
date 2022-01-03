using System.Collections.Generic;

namespace CleanArchitecture.Infrastructure.Interfaces
{
    public interface IPaginate<T>
    {
        int Count { get; }

        IList<T> Items { get; }
    }
}
