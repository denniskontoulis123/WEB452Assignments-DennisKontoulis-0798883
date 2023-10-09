using Microsoft.EntityFrameworkCore;
using MVCAssignment.Models;

namespace MVCAssignment.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<Smartphone> Smartphones {get;set;}
    }
}