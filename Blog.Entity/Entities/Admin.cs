using Blog.Core.Entities.Abstraction;
using Blog.Core.Entities.Concretes;
using System.ComponentModel.DataAnnotations;

namespace Blog.Entity.Entities
{
    public class Admin : EntityBase, IEntityBase
    {
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
    }
}
