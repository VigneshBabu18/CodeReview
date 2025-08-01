using Microsoft.EntityFrameworkCore;
using ProductApi.Model;

namespace ProductApi.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }
    }
}
