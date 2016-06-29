using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAndVocabulary.Enum
{
    public enum EnumUser
    {
        /// <summary>
        /// 校验正确
        /// </summary>
        [Description("校验正确")]
        HandleCheckSuccess = 200,

        /// <summary>
        /// 异常，请稍后重试
        /// </summary>
        [Description("异常，请稍后重试")]
        HandleException = 201,

        /// <summary>
        /// 异常，请稍后重试
        /// </summary>
        [Description("用户名或密码错误")]
        HandleUserNameOrPsdError = 202,

        /// <summary>
        /// 已存在用户名
        /// </summary>
        [Description("用户名已存在")]
        HandleUserNameExists = 203,

        /// <summary>
        /// 已存在该邮箱
        /// </summary>
        [Description("邮箱已存在")]
        HandleEmailExists = 204,
    }
}
