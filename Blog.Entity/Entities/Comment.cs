using Blog.Core.Entities.Abstraction;
using Blog.Core.Entities.Concretes;

namespace Blog.Entity.Entities
{
    public class Comment : EntityBase, IEntityBase
    {
        public string CommentContent { get; set; }
        public virtual string? CreatedBy { get; set; }
        public virtual string? ModifiedBy { get; set; } // nullable olabilir
        public virtual string? DeletedBy { get; set; } // nullable olabilir
        public virtual DateTime? CreatedDate { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual DateTime? DeletedDate { get; set; }
        public virtual bool IsDeleted { get; set; } = false;
        public Guid ArticleID { get; set; }
        public Guid SubscriberId { get; set; }
    }
}
