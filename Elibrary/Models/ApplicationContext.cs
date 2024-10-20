using Microsoft.EntityFrameworkCore;

namespace Elibrary.Models
{
    public class ApplicationContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasKey(e => e.Id);
        }
        public DbSet<Book> Books { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }
    }
}
