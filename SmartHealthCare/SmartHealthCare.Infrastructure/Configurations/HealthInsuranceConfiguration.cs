using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartHealthCare.Domain.Entities;

namespace SmartHealthCare.Infrastructure.Configurations;

public class HealthInsuranceConfiguration : IEntityTypeConfiguration<HealthInsurance>
{
    public void Configure(EntityTypeBuilder<HealthInsurance> builder)
    {
        // builder.Property(hi => hi.InsuranceNumber)
        //     .IsRequired();
        builder.Property(hi => hi.ExpDate)
            .IsRequired();
        builder.Property(hi => hi.Status)
            .IsRequired();
    }
}