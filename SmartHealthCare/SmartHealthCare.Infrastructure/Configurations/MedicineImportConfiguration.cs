using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartHealthCare.Domain.Entities;

namespace SmartHealthCare.Infrastructure.Configurations;

public class MedicineImportConfiguration : IEntityTypeConfiguration<MedicineImport>
{
    public void Configure(EntityTypeBuilder<MedicineImport> builder)
    {
        builder.Property(p => p.Quantity)
            .IsRequired();
        builder.HasOne(mi => mi.Medicine)
            .WithMany(m => m.MedicineImports)
            .HasForeignKey(mi => mi.MedicineId);
    }
}