using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using PUMA.Shared.Entities;

namespace PUMA.Web.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet <User> Users { get; set; }
        public DbSet <Exercise> Exercises { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasIndex(x => x.Email).IsUnique();
            modelBuilder.Entity<User>().Property(u => u.Role).HasDefaultValue("Estudiante");
            modelBuilder.Entity<User>().Property(u => u.Active).HasDefaultValue(true);
            modelBuilder.Entity<User>().Property(u => u.Scorestreak).HasDefaultValue(0);
            modelBuilder.Entity<Course>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<Lesson>().Property(l => l.Title).IsRequired().HasMaxLength(200);
            modelBuilder.Entity<Lesson>().Property(l => l.Content).IsRequired().HasMaxLength(5000);
            modelBuilder.Entity<Lesson>().Property(l => l.Difficulty).IsRequired();
        }
    }
}
