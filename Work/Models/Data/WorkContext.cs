using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Work.Models.Data
{
    public class WorkContext:IdentityDbContext<User>
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Paper> Papers { get; set; }

        public WorkContext(DbContextOptions options) : base(options)
        {
        }
    }
}