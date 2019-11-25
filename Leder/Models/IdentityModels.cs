using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Leder.Models
{
    // 您可將更多屬性新增至 User 類別，藉此為使用者新增設定檔資料，如需深入了解，請瀏覽 https://go.microsoft.com/fwlink/?LinkID=317594。
    public class User : IdentityUser
    {

        [Key]
        public override string Id { get; set; }
        public int? UserDetailId { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
        [ForeignKey("UserDetailId")]
        public UserDetail UserDetail { get; set; }


    }
    public class UserDetail
    {

        [Key]
        public int UserDetailID { get; set; }
        //[RegularExpression(@"/^09[0-9]{8}$/")]
        [Display(Name = "行動電話")]
        public string CellPhone { get; set; }
        [Required]
        [Display(Name = "地址")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "運送地址")]
        public string ShipAddress { get; set; }
        [Display(Name = "生日")]
        public DateTime BirthDay { get; set; }
        [Required]
        //[RegularExpression(@"/^[A-Za-z][12]\d{8}$/",ErrorMessage ="輸入格式錯誤(例:A123456789)")]
        [Display(Name = "身分證")]
        public string IdentityCard { get; set; }


    }

    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("User").Property(x => x.Id).HasColumnName("UserID");
            modelBuilder.Entity<IdentityUserRole>().ToTable("UserRole");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClame").Property(x => x.Id).HasColumnName("UserClameId");
            modelBuilder.Entity<IdentityRole>().ToTable("Role").Property(x => x.Id).HasColumnName("RoleID");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("UserLogin");

        }
        //更改Identity本來的命名Convension，自定義所有的Table名稱
        public DbSet<UserDetail> UserDetail { get; set; } //實體化UserDetails表

    }
}