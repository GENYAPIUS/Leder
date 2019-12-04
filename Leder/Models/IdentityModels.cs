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

       
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
       


       
    }
   
    public class UserDetail //使用者詳細資料的欄位，正規化還沒開。
    {

        [Key]
        public int UserDetailID { get; set; }
        //[RegularExpression(@"/^09[0-9]{8}$/")]
        [Required]
        [Display(Name = "地址")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "運送地址")]
        public string ShipAddress { get; set; }
        [Display(Name = "生日")]
        
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]//記得加後面那行，不然在textBox還是會顯示上午12:00:00
        public DateTime BirthDay { get; set; }
        [Required]
        //[RegularExpression(@"/^[A-Za-z][12]\d{8}$/",ErrorMessage ="輸入格式錯誤(例:A123456789)")]
        [Display(Name = "身分證")]
        public string IdentityCard { get; set; }

        public string Email { get; set; } //跟User裡面的UserName同名且絕不重複，拿來當作索引鍵。


    }

    //public class LederContext : IdentityDbContext<User>
    //{
    //    public LederContext()
    //        : base("LederDatabase", throwIfV1Schema: false)
    //    {
    //    }

    //    public static LederContext Create()
    //    {
    //        return new LederContext();
    //    }
    //    public DbSet<UserDetail> UserDetail { get; set; } //實體化UserDetails表
    //}
}