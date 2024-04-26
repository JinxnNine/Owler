using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Owler.Models;

namespace Owler.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public override DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<User>()
                .Ignore(u => u.PhoneNumber).Ignore(u => u.PhoneNumberConfirmed)
                .Ignore(u => u.LockoutEnabled).Ignore(u => u.LockoutEnd)
                .Ignore(u => u.AccessFailedCount).Ignore(u => u.TwoFactorEnabled).ToTable("Users", "public");

            builder.Entity<IdentityRole>().ToTable("Roles", "public");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles", "public");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims", "public");

            builder.Entity<User>().HasMany(q => q.StudentClasses).WithMany(s => s.Users).UsingEntity<UserClass>();
            builder.Entity<User>().HasMany(q => q.StudentQuizzes).WithMany(s => s.Users).UsingEntity<UserQuiz>();
            builder.Entity<User>().HasMany(q => q.StudentAssignments).WithMany(s => s.Users).UsingEntity<UserAssignment>();

            builder.Entity<Class>().HasOne(q => q.Teacher).WithMany(s => s.TeacherClasses).HasForeignKey(d => d.TeacherId);
            builder.Entity<Quiz>().HasOne(q => q.Teacher).WithMany(s => s.TeacherQuizzes).HasForeignKey(d => d.TeacherId);
            builder.Entity<Assignment>().HasOne(q => q.Teacher).WithMany(s => s.TeacherAssignments).HasForeignKey(d => d.TeacherId);

            base.OnModelCreating(builder);
        }


        public DbSet<Class> Classes { get; set; }
        public DbSet<UserClass> UserClass { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<UserQuiz> UserQuizzes { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<UserAssignment> UserAssignments { get; set; }

    }
}