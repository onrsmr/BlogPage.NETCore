﻿using Blog.Core.Entities.Abstraction;
using Blog.Core.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Entities
{
    public class Image : EntityBase, IEntityBase
    {
        public string FileName { get; set; }
        public string FileType { get; set; }
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