using Logis.Models;
using Microsoft.EntityFrameworkCore;

namespace Logis.DAL
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options):base(options)
        {
            
        }
        public DbSet<Service> Services { get; set; }
    }
}
