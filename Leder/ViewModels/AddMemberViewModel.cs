using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Leder.ViewModels
{
    public class AddMemberViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "電子信箱")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} 的長度至少必須為 {2} 個字元。", MinimumLength = 8)]//要跟當初資料庫預設的一樣
        [DataType(DataType.Password)]
        [Display(Name = "密碼")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "確認密碼")]
        [Compare("Password", ErrorMessage = "密碼和確認密碼不相符。")]
        public string ConfirmPassword { get; set; }

        [RegularExpression(@"^09[0-9]{8}$", ErrorMessage = "輸入格式錯誤(例:0912345678)")]
        [Display(Name = "行動電話")]
        public string CellPhone { get; set; }

        [Required]
        [Display(Name = "住家地址")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "運送地址")]
        public string ShipAddress { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        [Display(Name = "生日")]
        public DateTime BirthDate { get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z][12]\d{8}$", ErrorMessage = "輸入格式錯誤(例:A123456789)")]
        [Display(Name = "身分證")]
        public string IdentityCard { get; set; }
    }
}