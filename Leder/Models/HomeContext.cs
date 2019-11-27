namespace Leder.ViewModels
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HomeContext : DbContext
    {
        public HomeContext()
            : base("name=HomeContext")
        {
        }
        public DbSet<PromoteProductViewModel> promoteProducts { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
