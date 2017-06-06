using System.Data.Entity;

namespace CheckTicketsBack.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<User> Users { get; set; }
    }
}