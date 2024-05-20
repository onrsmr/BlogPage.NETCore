using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mapping
{
    public class SubscriberMapping : IEntityTypeConfiguration<Subscriber>
    {
        public void Configure(EntityTypeBuilder<Subscriber> builder)
        {
            builder.HasData(new Subscriber
            {
                Id = SeedGuidIDs.subscriberId,
                Name = "SubName1",
                Surname = "SubSurname1",
                UserName = "SubUserName",
                Email = "subscriber@subsriber.com",
                Password = "Password",
                IsActive = true,
                CommentId = SeedGuidIDs.commentId,
            });
        }
    }
}
