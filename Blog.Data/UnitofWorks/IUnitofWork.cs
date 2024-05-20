using Blog.Core.Entities.Abstraction;
using Blog.Data.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.UnitofWorks
{
    public interface IUnitofWork : IAsyncDisposable
    {
        IRepository<T> GetRepository<T>() where T : class, IEntityBase, new();

        Task<int> SaveAsync();
        int Save();
    }
}
