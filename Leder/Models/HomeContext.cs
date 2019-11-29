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
        public DbSet<SliderPartialViewModel> sliders { get; set; }
        public DbSet<ProductsSectionViewModel> productsSections { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
