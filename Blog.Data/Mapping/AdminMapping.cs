using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mapping
{
    public class AdminMapping : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasData(new Admin
            {
                Id = SeedGuidIDs.adminId,
                Name = "admin",
                Surname = "admin",
                UserName = "admin",
                Email = "admin@admin.com",
                Password = "adm!n",
            });
        }
    }
}
