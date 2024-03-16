using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Owler.Models;

namespace Owler.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Class> Classes { get; set; }
        public DbSet<UserClass> UserClass { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Assignment> Assignments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<User>().ToTable("Users")
                .Ignore(u => u.PhoneNumber).Ignore(u => u.PhoneNumberConfirmed)
                .Ignore(u => u.LockoutEnabled).Ignore(u => u.LockoutEnd)
                .Ignore(u => u.AccessFailedCount).Ignore(u => u.TwoFactorEnabled);

            builder.Entity<IdentityRole>().ToTable("Roles", "security");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");

            builder.Entity<User>().HasMany(q => q.Classes).WithMany(s => s.Users).UsingEntity<UserClass>();
            builder.Entity<User>().HasMany(q => q.Quizzes).WithMany(s => s.Users).UsingEntity<UserQuiz>();
            builder.Entity<User>().HasMany(q => q.Assignments).WithMany(s => s.Users).UsingEntity<UserAssignment>();
            
            
            base.OnModelCreating(builder);
        }
    }
}