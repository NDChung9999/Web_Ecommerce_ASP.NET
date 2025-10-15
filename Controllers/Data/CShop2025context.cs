using Microsoft.EntityFrameworkCore;
using MyMvcApp.Models;

namespace MyMvcApp.Data
{
    public class CShop2025Context : DbContext
    {
        public CShop2025Context(DbContextOptions<CShop2025Context> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
