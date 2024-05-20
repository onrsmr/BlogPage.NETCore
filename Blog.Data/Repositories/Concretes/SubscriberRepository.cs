using Blog.Data.Context;
using Blog.Data.Repositories.Abstractions;
using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Repositories.Concretes
{
    public class SubscriberRepository : RepositoryRC<Subscriber>, ISubscriberRepository
    {
        private readonly AppDbContext _appDbContext;
        public SubscriberRepository(AppDbContext db) : base(db)
        {
            _appDbContext = db;
        }
    }
}
