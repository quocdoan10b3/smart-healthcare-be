using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartHealthCare.Domain.Entities;

namespace SmartHealthCare.Infrastructure.Configurations;

public class FeedBackConfiguration : IEntityTypeConfiguration<FeedBack>
{
    public void Configure(EntityTypeBuilder<FeedBack> builder)
    {
        builder.Property(fb => fb.Rating)
            .IsRequired();
        builder.Property(fb => fb.Comments)
            .IsRequired();
        builder.Property(fb => fb.CommentDate)
            .IsRequired();
        builder.Property(fb => fb.Response)
            .IsRequired(false);
        builder.Property(fb => fb.ResponseDate)
            .IsRequired(false);
    }
}