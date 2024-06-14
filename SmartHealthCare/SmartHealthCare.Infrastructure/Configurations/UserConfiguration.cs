using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartHealthCare.Domain;
using SmartHealthCare.Domain.Entities;

namespace SmartHealthCare.Infrastructure.Configurations;

public class ApplicationUserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasIndex(u => u.UserName).IsUnique();
        builder.HasIndex(u => u.Email).IsUnique();

        builder.Property(u => u.FullName)
            .IsRequired()
            .HasMaxLength(StringLength.Name);

        builder.Property(u => u.PhoneNumber)
            .HasMaxLength(StringLength.Phone);
        builder.Property(u => u.Role)
            .IsRequired();
        builder.HasMany(s => s.Notifications)
            .WithOne(n => n.User)
            .HasForeignKey(n => n.UserId)
            .OnDelete(DeleteBehavior.NoAction);
        builder.Property(u => u.AvatarUrl)
            .HasMaxLength(StringLength.Url);
        
        builder.HasData(
            new User
            {
                Id = 1,
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "example@gmail.com",
                NormalizedEmail = "EXAMPLE@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null!, "Admin@123"),
                SecurityStamp = Guid.NewGuid().ToString(),
                FullName = "Admin",
            });
    }
}

public class ApplicationRoleConfiguration : IEntityTypeConfiguration<IdentityRole<int>>
{
    public void Configure(EntityTypeBuilder<IdentityRole<int>> builder)
    {
        builder.HasData(
            new IdentityRole<int>
            {
                Id = 1,
                Name = "admin",
                NormalizedName = "ADMIN"
            },
            new IdentityRole<int>
            {
                Id = 2,
                Name = "student",
                NormalizedName = "STUDENT"
            },
            new IdentityRole<int>
            {
                Id = 3,
                Name = "staff",
                NormalizedName = "STAFF"
            }
        );
    }
}

public class ApplicationUserRoleConfig : IEntityTypeConfiguration<IdentityUserRole<int>>
{
    public void Configure(EntityTypeBuilder<IdentityUserRole<int>> builder)
    {
        builder.HasData(
            new IdentityUserRole<int>
            {
                RoleId = 1,
                UserId = 1
            });
    }
}
