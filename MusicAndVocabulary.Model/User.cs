using MusicAndVocabulary.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAndVocabulary.Model
{
    public class User
    {
        /// <summary>
        /// 用户id
        /// </summary>
        [Key]
        public int UserId { get; set; }

        /// <summary>
        /// 用户唯一Guid
        /// </summary>
        public string UserGId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public EnumStatus Status { get; set; }

        /// <summary>
        /// 头像图片链接
        /// </summary>
        public virtual string ImgUrl { get; set; }
    }
}
