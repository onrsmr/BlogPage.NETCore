using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mapping
{
    public class ImageMapping : IEntityTypeConfiguration<Image>
    {

        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                Id = SeedGuidIDs.imageId,
                FileName = "images/asptestimage",
                FileType = "jpg",
                CreatedBy = "Admin test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            });
        }
    }
}
