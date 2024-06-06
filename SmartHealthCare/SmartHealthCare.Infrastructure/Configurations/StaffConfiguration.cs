using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartHealthCare.Domain.Entities;

namespace SmartHealthCare.Infrastructure.Configurations;

public class StaffConfiguration : IEntityTypeConfiguration<Staff>
{
    public void Configure(EntityTypeBuilder<Staff> builder)
    {
        builder.Property(s => s.Date)
            .IsRequired();
        builder.Property(s => s.Gender)
            .IsRequired();
        builder.Property(s => s.Address)
            .IsRequired(false);
        builder.HasMany(s => s.HealthRecords)
            .WithOne(hr => hr.Staff)
            .HasForeignKey(hr => hr.StaffId)
            .OnDelete(DeleteBehavior.NoAction);
        builder.HasMany(s => s.Histories)
            .WithOne(h => h.Staff)
            .HasForeignKey(h=>h.StaffId)
            .OnDelete(DeleteBehavior.NoAction);
        builder.HasMany(s => s.HealthInsurances)
            .WithOne(hi => hi.Staff)
            .HasForeignKey(hi => hi.StaffId)
            .OnDelete(DeleteBehavior.NoAction);
        builder.HasMany(s => s.Notifications)
            .WithOne(n => n.Staff)
            .HasForeignKey(n => n.StaffId);
        builder.HasMany(s => s.MedicineImports)
            .WithOne(n => n.Staff)
            .HasForeignKey(n => n.StaffId);
        builder.HasOne(s => s.User)
            .WithOne(u => u.Staff)
            .HasForeignKey<Staff>(s=>s.UserId);
    }
}