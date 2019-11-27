using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Leder.Models
{
    public partial class ShoppingCartContext:DbContext
    {
        public ShoppingCartContext() : base("DefaultConnection") { }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order_Details> Order_Details { get; set; }
    }
}