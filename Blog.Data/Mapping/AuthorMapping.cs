using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mapping
{
    public class AuthorMapping : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData(new Author
            {
                Id = SeedGuidIDs.authorId,
                Name = "Author1",
                Surname = "Author1",
                UserName = "author1",
                Email = "author@author.com",
                Password = "Password",
                ArticleId = SeedGuidIDs.articleId,
            });
        }
    }
}
