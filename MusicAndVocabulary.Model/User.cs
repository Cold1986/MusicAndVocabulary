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
        [Index("TitleIndex", IsUnique = true)]
        public int UserId { get; set; }

        /// <summary>
        /// 用户唯一Guid
        /// </summary>
        [Index(IsUnique = true)]
        public Guid UserGId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [Index(IsUnique = true)]
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [Index(IsUnique = true)]
        public string Email { get; set; }

        /// <summary>
        /// 头像图片链接
        /// </summary>
        public virtual string ImgUrl { get; set; }
    }
}
