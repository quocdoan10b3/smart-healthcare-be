using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace SmartHealthCare.Domain.Entities;

public class User : IdentityUser<int>
{
    public string? AvatarUrl { get; set; }
    public string FullName { get; set; } = string.Empty;
    [MaxLength(10)]
    public string Role { get; set; } = string.Empty;
    public Student? Student { get; set; }
    public Staff? Staff { get; set; }
    public ICollection<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();
}