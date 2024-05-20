using Blog.Core.Entities.Abstraction;
using Blog.Core.Entities.Concretes;
using System.ComponentModel.DataAnnotations;

namespace Blog.Entity.Entities
{
    public class Author : EntityBase, IEntityBase
    {
        public Author()
        {
                Articles = new HashSet<Article>();   
        }
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
        public Guid ArticleId { get; set; } //????
        public ICollection<Article> Articles { get; set; }
    }
}
