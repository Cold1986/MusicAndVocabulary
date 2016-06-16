using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicAndVocabulary.ViewModels
{
    public class RegisterViewModel
    {

        [Required]
        [StringLength(20,ErrorMessage = "{0} 至少 {2} 个字节.", MinimumLength =4)]
        [Display(Name = "用户名")]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "邮箱")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = " {0} 至少 {2} 个字节.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "密码确认")]
        [Compare("Password", ErrorMessage = "两次密码不一致.")]
        public string ConfirmPassword { get; set; }
    }
}