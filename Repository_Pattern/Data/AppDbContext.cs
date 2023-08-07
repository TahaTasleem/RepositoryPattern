using Repository_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext() : base(ConfigurationManager.ConnectionStrings["Db"].ConnectionString) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Reviews> Review { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
