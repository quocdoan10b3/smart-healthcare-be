using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartHealthCare.Domain.Entities;

namespace SmartHealthCare.Infrastructure.Configurations;

public class NotificationConfiguration : IEntityTypeConfiguration<Notification>
{
    public void Configure(EntityTypeBuilder<Notification> builder)
    {
        builder.Property(p => p.Title)
            .IsRequired();
        builder.Property(p => p.Content)
            .IsRequired();
        builder.Property(p => p.Image)
            .IsRequired(false);
    }
}