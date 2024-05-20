using Blog.Core.Entities.Abstraction;

namespace Blog.Core.Entities.Concretes
{
    public abstract class EntityBase : IEntityBase
    {
        public virtual Guid Id { get; set; }
    }
}
