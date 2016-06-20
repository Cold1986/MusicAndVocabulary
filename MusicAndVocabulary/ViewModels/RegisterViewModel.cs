using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicAndVocabulary.ViewModels
{
    public class RegisterViewModel
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [Required]
        [StringLength(20,ErrorMessage = "{0} 至少 {2} 个字节.", MinimumLength =4)]
        [Display(Name = "用户名")]
        public string UserName { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [Required]
        [EmailAddress]
        [Display(Name = "邮箱")]
        public string Email { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Required]
        [StringLength(100, ErrorMessage = " {0} 至少 {2} 个字节.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        public string Password { get; set; }

        /// <summary>
        /// 密码确认
        /// </summary>
        [DataType(DataType.Password)]
        [Display(Name = "密码确认")]
        [Compare("Password", ErrorMessage = "两次密码不一致.")]
        public string ConfirmPassword { get; set; }


        [Required]
        [Display(Name = "验证码")]
        public string ValidateCode { get; set; }
    }
}