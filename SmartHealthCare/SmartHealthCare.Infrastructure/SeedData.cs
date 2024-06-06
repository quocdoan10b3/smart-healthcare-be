using System.Reflection.Emit;
using Bogus;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SmartHealthCare.Domain.Entities;

namespace SmartHealthCare.Infrastructure;

public static class SeedData
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        var users = GetUsers();
        modelBuilder.Entity<User>().HasData(users);
        var students = GetStudents(users);
        modelBuilder.Entity<Student>().HasData(students);
        
    }
    private static List<User> GetUsers()
    {
        return new Faker<User>()
            // admin co id = 1 nen o day la 2
            .RuleFor(u => u.Id, f => f.IndexFaker + 2)
            .RuleFor(u => u.FullName, f => f.Name.FullName())
            .RuleFor(u => u.Email, f => f.Internet.Email())
            .RuleFor(u => u.NormalizedEmail, (_,
                u) => u.Email?.ToUpper())
            .RuleFor(u => u.UserName, (f,
                u) =>
            {
                var year = f.Random.Int(2020, 2023).ToString();
                var stt = f.Random.Int(1, 999).ToString("D3");
                return $"HS{year}{stt}";
            })
            .RuleFor(u => u.NormalizedUserName, (_,
                u) => u.UserName?.ToUpper())
            .RuleFor(u => u.EmailConfirmed, _ => true)
            .RuleFor(u => u.SecurityStamp, _ => Guid.NewGuid().ToString())
            .RuleFor(u => u.PasswordHash, _ => new PasswordHasher<User>().HashPassword(null!, "User@123"))
            .Generate(10);
    }

    private static List<Student> GetStudents(List<User> listUsers)
    {
        int i = 1;
        List<Student> students = new List<Student>();
        foreach (var user in listUsers)
        {
            var student = new Faker<Student>().RuleFor(s => s.StudentCode, _ => user.UserName)
                .RuleFor(s => s.Class, f => "9/1")
                .RuleFor(s => s.Date, f => f.Date.Between(new DateTime(2008, 01, 01), new DateTime(2018, 12, 31)))
                .RuleFor(s => s.Gender, f => f.Random.Bool())
                .RuleFor(s => s.Address, f => f.Address.FullAddress())
                .RuleFor(s => s.UserId, f => user.Id)
                .RuleFor(s => s.Id, f => i++)
                .Generate(1);
            students.AddRange(student);
        }

        return students;
    }
}