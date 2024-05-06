using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartHealthCare.Domain.Entities;

namespace SmartHealthCare.Infrastructure.Configurations;

public class HealthRecordConfiguration : IEntityTypeConfiguration<HealthRecord>
{
    public void Configure(EntityTypeBuilder<HealthRecord> builder)
    {
        builder.Property(hr => hr.ExamDate);
        builder.Property(hr => hr.Height);
        builder.Property(hr => hr.Weight);
        builder.Property(hr => hr.Vision);
        builder.Property(hr => hr.Hearing);
        builder.Property(hr => hr.DentalHealth);
        builder.Property(hr => hr.Allergies);
        builder.Property(hr => hr.Notes);
    }
}