using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using PUMA.Shared.Entities;

namespace PUMA.Web.Data
{
    public class DataContext: DbContext
    {
        public DbSet <User> Users { get; set; }

        public DataContext(DbContextOptions <DataContext> options): base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasIndex(x => x.Email).IsUnique();
        }
    }
}
