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
    public class ArticleRepositoryRC : RepositoryRC<Article>, IArticleRepositoryRC
    {
        private readonly AppDbContext db;

        public ArticleRepositoryRC(AppDbContext db) : base(db)
        {
            this.db = db;
        }
    }
}
