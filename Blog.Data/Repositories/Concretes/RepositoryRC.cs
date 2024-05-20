using Blog.Core.Entities.Concretes;
using Blog.Data.Context;
using Blog.Data.Repositories.Abstractions;
using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Repositories.Concretes
{
    public class RepositoryRC<T> : IRepositoryRC<T> where T : EntityBase
    {
        private readonly AppDbContext db;
        public RepositoryRC(AppDbContext db)
        {
            this.db = db; 
        }
        public bool Add(T entity)
        {
            try
            {
                db.Set<T>().Add(entity);
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false; ;
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                db.Set<T>().Remove(entity);
                return db.SaveChanges() > 0;
            }
            catch
            {

                return false;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return db.Set<T>();
        }

        public T GetByID(Guid id)
        {
            return db.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public Author GetByID(object ıd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetWhere(Expression<Func<T, bool>> predicate)
        {
            return db.Set<T>().Where(predicate);
        }

        public T SingleOrDefault(Expression<Func<T, bool>> predicate)
        {
            return db.Set<T>().SingleOrDefault(predicate);
        }

        public bool Update(T entity)
        {
            try
            {
                //Update metodu içine gönderilen entity'de id varsa ilgili id'ye sahip entity'yi update eder, id yok ise add gibi çalışır. Bu sebeple tek bir AddOrUpdate metodu da kullanılabilir
                db.Set<T>().Update(entity);
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
