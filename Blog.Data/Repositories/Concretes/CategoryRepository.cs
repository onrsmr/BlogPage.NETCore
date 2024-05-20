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
    public class CategoryRepository : RepositoryRC<Category>, ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;
        public CategoryRepository(AppDbContext db) : base(db)
        {
            _appDbContext = db;
        }
    }
}
