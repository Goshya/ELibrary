using Microsoft.EntityFrameworkCore;

namespace Elibrary.Models
{
    public class ApplicationContext : DbContext
    {
        DbSet<Book> Books { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }
    }
}
