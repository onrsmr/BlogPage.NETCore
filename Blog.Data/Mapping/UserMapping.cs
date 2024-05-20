using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mapping
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(new User
            {
                Id = SeedGuidIDs.userId,
                Name = "NameofUser1",
                Surname = "SurnameOfUser1",
                UserName = "username",
                Email = "user@user.com",
                Password = "Password",
                IsAdmin = false,
                IsUser = true
            });
        }
    }
}
