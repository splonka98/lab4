using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoping.Models
{
    public class ShopingContext : DbContext
    {
        internal readonly object Shoping;

        public ShopingContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ShopingModel> Products { get; set; }
    }
}
