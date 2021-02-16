using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Work.Models.Data
{
    public class WorkContext:IdentityDbContext<User>
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Paper> Papers { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }

        public WorkContext(DbContextOptions options) : base(options)
        {
        }
    }
}