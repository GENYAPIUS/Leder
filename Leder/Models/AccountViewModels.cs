using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Leder.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "電子信箱")]
        public string Email { get; set; }

        //[RegularExpression(@"/^09[0-9]{8}$/")]
        [Display(Name = "行動電話")]
        public string CellPhone { get; set; }
        [Required]
        [Display(Name = "住家地址")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "運送地址")]
        public string ShipAddress { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "生日")]
        public DateTime BirthDate { get; set; }
        [Required]
        //[RegularExpression(@"/^[A-Za-z][12]\d{8}$/", ErrorMessage = "輸入格式錯誤(例:A123456789)")]
        [Display(Name = "身分證")]
        public string IdentityCard { get; set; }

    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "代碼")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "記住此瀏覽器?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "電子郵件")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "電子郵件")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "密碼")]
        public string Password { get; set; }

        [Display(Name = "記住我?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel //註冊時的ViewModel，我加了其他必備欄位。
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
        //[RegularExpression(@"/^09[0-9]{8}$/")]
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
        //[RegularExpression(@"/^[A-Za-z][12]\d{8}$/", )ErrorMessage = "輸入格式錯誤(例:A123456789)")]
        [Display(Name = "身分證")]
        public string IdentityCard { get; set; }
        //[RegularExpression("(True|true)", ErrorMessage = "請閱讀隱私權政策後打勾。")]
        //[Range(typeof(bool), "true", "true", ErrorMessage = "請閱讀隱私權政策後打勾。")]
        //[StringLength(4, ErrorMessage = "請閱讀隱私權政策後打勾。")]
        public bool IsTrue => true;

        [Required]
        [Display(Name = "請閱讀隱私權政策後打勾。")]
        [Compare("IsTrue", ErrorMessage = "請閱讀隱私權政策後打勾。")]
        //[Display(Name = "隱私權政策")]
        public bool PrivatePolicy_Checked { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "電子郵件")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} 的長度至少必須為 {2} 個字元。", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "密碼")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "確認密碼")]
        [Compare("Password", ErrorMessage = "密碼和確認密碼不相符。")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "電子郵件")]
        public string Email { get; set; }
    }
}
