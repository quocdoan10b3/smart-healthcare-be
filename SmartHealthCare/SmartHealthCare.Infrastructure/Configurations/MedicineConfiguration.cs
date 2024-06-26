using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartHealthCare.Domain.Entities;

namespace SmartHealthCare.Infrastructure.Configurations;

public class MedicineConfiguration : IEntityTypeConfiguration<Medicine>
{
    public void Configure(EntityTypeBuilder<Medicine> builder)
    {
        builder.Property(m => m.Name)
            .IsRequired();

        builder.Property(m => m.Effect)
            .IsRequired(false);
        builder.Property(m => m.ImageMedicine)
            .IsRequired(false);
        builder.HasMany(m => m.Prescriptions)
            .WithOne(p => p.Medicine)
            .HasForeignKey(p => p.MedicineId);
    }
}