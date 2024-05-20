using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mapping
{
    public class ArticleMapping : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            // SEED DATA OLUŞTUR
            builder.HasData(new Article
            {
                Id = SeedGuidIDs.articleId,
                Title = "Asp.Net Core Hakkında",
                Content = "Asp.Net Core, Lorem, ipsum dolor sit amet consectetur adipisicing elit. Adipisci, corrupti?",
                ViewCount = 15,
                CategoryId = SeedGuidIDs.categoryId,
                ImageId = SeedGuidIDs.imageId,
                AuthorId = SeedGuidIDs.authorId,
                CreatedBy = "Admin test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            });
        }
    }
}
