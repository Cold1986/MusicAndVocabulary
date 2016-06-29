using System.ComponentModel.DataAnnotations;

namespace MusicAndVocabulary.ViewModels
{
    public class LoginViewModel
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [Required]
        [StringLength(20, ErrorMessage = "{0} 至少 {2} 个字节.", MinimumLength = 4)]
        [Display(Name = "用户名")]
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Required]
        [StringLength(100, ErrorMessage = " {0} 至少 {2} 个字节.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        public string Password { get; set; }

        /// <summary>
        /// 记住登录
        /// </summary>
        [Display(Name = "记住登录")]
        public bool RememberMe { get; set; }

        /// <summary>
        /// 验证码
        /// </summary>
        [Required]
        [Display(Name = "验证码")]
        public string ValidateCode { get; set; }
    }
}