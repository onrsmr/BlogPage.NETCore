using Blog.Core.Entities.Concretes;
using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Repositories.Abstractions
{
    public interface IRepositoryRC<T> where T : EntityBase
    {
        IEnumerable<T> GetAll();
        T GetByID(Guid id);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        IEnumerable<T> GetWhere(Expression<Func<T, bool>> predicate);
        T SingleOrDefault(Expression<Func<T, bool>> predicate);
        Author GetByID(object ıd);
    }
}
