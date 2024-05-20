using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mapping
{
    public class CategoryMApping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = SeedGuidIDs.categoryId,
                CategoryName = "Asp.Net Core",
                CreatedBy = "Admin test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            });
        }
    }
}
