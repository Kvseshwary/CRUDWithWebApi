using CRUDWithWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDWithWebApi.DAL
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
