using Microsoft.EntityFrameworkCore;
using ContosoPets.Api.Models;

namespace Core.Data
{
    public class EMSContext : DbContext
    {
        public EMSContext(DbContextOptions<EMSContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}