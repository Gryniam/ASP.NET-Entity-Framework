using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace labshop.Models
{
    public class ShopContext : DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<Tovar> tovars { get; set; }
        public DbSet<BuyTovar> buyTovars { get; set; }
        public DbSet<Download> downloads { get; set; }
        public ShopContext(DbContextOptions<ShopContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
