using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mapping
{
    public class CommentMapping : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasData(new Comment
            {
                Id = SeedGuidIDs.commentId,
                ArticleID = SeedGuidIDs.articleId,
                SubscriberId = SeedGuidIDs.subscriberId,
                CommentContent = "Harika bir içerik! Teşekkürler Admin",
            });
        }
    }
}
