using Blog.Data.Context;
using Blog.Data.Repositories.Abstractions;
using Blog.Data.Repositories.Concretes;

namespace Blog.Data.UnitofWorks
{
    public class UnitofWork : IUnitofWork
    {
        private readonly AppDbContext appDbContext;

        public UnitofWork(AppDbContext _appDbContext)
        {
            appDbContext = _appDbContext;
        }


        public async ValueTask DisposeAsync()
        {
            await appDbContext.DisposeAsync();
        }

        public int Save()
        {
            return appDbContext.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await appDbContext.SaveChangesAsync();
        }

        IRepository<T> IUnitofWork.GetRepository<T>()
        {
            return new Repository<T>(appDbContext);
        }
    }
}
