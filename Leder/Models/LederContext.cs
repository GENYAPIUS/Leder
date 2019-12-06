using Leder.ViewModels;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Leder.Models
{
    public class LederContext : IdentityDbContext<User>
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public LederContext() : base("name=LederDatabase", throwIfV1Schema: false) { }

        public static LederContext Create() { return new LederContext(); }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<UserDetail> UserDetail { get; set; } //實體化UserDetails表

        public DbSet<Procurement> Procurement { get; set; }

        public System.Data.Entity.DbSet<Leder.ViewModels.PromoteProductViewModel> PromoteProductViewModels { get; set; }
    }
}
