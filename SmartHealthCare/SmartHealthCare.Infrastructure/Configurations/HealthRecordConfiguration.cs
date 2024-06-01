using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartHealthCare.Domain.Entities;

namespace SmartHealthCare.Infrastructure.Configurations;

public class HealthRecordConfiguration : IEntityTypeConfiguration<HealthRecord>
{
    public void Configure(EntityTypeBuilder<HealthRecord> builder)
    {
        builder.Property(hr => hr.ExamDate)
            .IsRequired();
        builder.Property(hr => hr.Height)
            .IsRequired();
        builder.Property(hr => hr.Weight)
            .IsRequired();
        builder.Property(hr => hr.Vision)
            .IsRequired();
        builder.Property(hr => hr.Hearing)
            .IsRequired();
        builder.Property(hr => hr.DentalHealth)
            .IsRequired();
        builder.Property(hr => hr.Allergies)
            .IsRequired();
        builder.Property(hr => hr.Notes)
            .IsRequired();
        builder.Property(hr => hr.Scholastic)
            .IsRequired();
    }
}