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
    public class AuthorRepository : RepositoryRC<Author>, IAuthorRepository
    {
        private readonly AppDbContext db;
        public AuthorRepository(AppDbContext db) : base(db)
        {
            this.db = db;
        }
    }
}
