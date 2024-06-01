using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartHealthCare.Domain.Entities;

namespace SmartHealthCare.Infrastructure.Configurations;

public class HistoryConfiguration : IEntityTypeConfiguration<History>
{
    public void Configure(EntityTypeBuilder<History> builder)
    {
        builder.Property(h => h.UsageDate)
            .IsRequired();
        builder.Property(h => h.Reason)
            .IsRequired(false);
        builder.HasMany(s => s.Prescriptions)
            .WithOne(p => p.History)
            .HasForeignKey(p => p.HistoryId);
    }
}