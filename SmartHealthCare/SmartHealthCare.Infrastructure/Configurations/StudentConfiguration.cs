using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartHealthCare.Domain.Entities;

namespace SmartHealthCare.Infrastructure.Configurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.Property(s => s.StudentCode);
        builder.Property(s => s.Class);
        builder.Property(s => s.Date);
        builder.Property(s => s.Gender);
        builder.Property(s => s.Address)
            .IsRequired(false);
        builder.HasMany(s => s.HealthRecords)
            .WithOne(hr => hr.Student)
            .HasForeignKey(hr => hr.StudentId);
        builder.HasMany(s => s.Histories)
            .WithOne(h => h.Student)
            .HasForeignKey(h=>h.StudentId);
        builder.HasMany(s => s.HealthInsurances)
            .WithOne(hi => hi.Student)
            .HasForeignKey(hi => hi.StudentId);
        builder.HasMany(s => s.FeedBacks)
            .WithOne(fb => fb.Student)
            .HasForeignKey(fb => fb.StudentId);
        builder.HasOne(s => s.User)
            .WithOne(u => u.Student)
            .HasForeignKey<Student>(u=>u.UserId);
    }
}