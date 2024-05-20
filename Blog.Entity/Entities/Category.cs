using Blog.Core.Entities.Abstraction;
using Blog.Core.Entities.Concretes;

namespace Blog.Entity.Entities
{
    public class Category : EntityBase, IEntityBase
    {
        public string CategoryName { get; set; }
        public virtual string? CreatedBy { get; set; }
        public virtual string? ModifiedBy { get; set; } // nullable olabilir
        public virtual string? DeletedBy { get; set; } // nullable olabilir
        public virtual DateTime? CreatedDate { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual DateTime? DeletedDate { get; set; }
        public virtual bool IsDeleted { get; set; } = false;
        public ICollection<Article> Articles { get; set; }
    }
}
