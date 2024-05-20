using Blog.Core.Entities.Abstraction;
using Blog.Core.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Entities
{
    public class Article : EntityBase, IEntityBase
    {

        public string Title { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public Guid ImageId { get; set; }
        public Image Image { get; set; }
        public Guid AuthorId { get; set; }
        public Author Author { get; set; }
        public virtual string? CreatedBy { get; set; }
        public virtual string? ModifiedBy { get; set; } // nullable olabilir
        public virtual string? DeletedBy { get; set; } // nullable olabilir
        public virtual DateTime? CreatedDate { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual DateTime? DeletedDate { get; set; }
        public virtual bool IsDeleted { get; set; } = false;


        public ICollection<Comment> Comments { get; set;}
    }
}
