using Blog.Core.Entities.Abstraction;
using Blog.Core.Entities.Concretes;

namespace Blog.Entity.Entities
{
    public class User : EntityBase, IEntityBase
    {
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsUser { get; set; }
    }
}
