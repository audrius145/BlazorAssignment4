using Assignment3API.Model;
using Microsoft.EntityFrameworkCore;

namespace Assignment3API.Persistence
{
    public class Assignment4DBContext : DbContext
    {
        public DbSet<Adult> Adults { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // name of database
            optionsBuilder.UseSqlite("Data Source = Assignment4.db");
        }
    }
}