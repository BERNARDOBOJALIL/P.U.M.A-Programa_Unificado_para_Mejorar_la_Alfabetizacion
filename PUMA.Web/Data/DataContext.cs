using Microsoft.EntityFrameworkCore;
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
            modelBuilder.Entity<User>().HasIndex(x => x.Name).IsUnique();
        }
    }
}
