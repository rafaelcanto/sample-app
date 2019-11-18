using Microsoft.EntityFrameworkCore;
using sample_app.Models;

namespace sample_app.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext (DbContextOptions<ProductContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
    }
}