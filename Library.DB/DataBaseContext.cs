using Library.DB.EntityModels;
using Microsoft.EntityFrameworkCore;

namespace Library.DB
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Librarian> Librarians { get; set; }
        public DbSet<Reader> Readers { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-6K5AE61\\SQLEXPRESS;Database=Library;" +
                                        "Trusted_Connection=True;");
        }
    }
}