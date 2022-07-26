using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc_.Models
{
    public class SalesWebMvc_Context : DbContext
    {
        public SalesWebMvc_Context(DbContextOptions<SalesWebMvc_Context> options)
            : base(options)
        {
        }

        public DbSet<Departament> Departament { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}