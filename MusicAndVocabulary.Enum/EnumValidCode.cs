using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAndVocabulary.Enum
{
    public enum EnumValidCode
    {
        /// <summary>
        /// 校验正确
        /// </summary>
        [Description("校验正确")]
        HandleCheckSuccess = 100,

        /// <summary>
        /// 异常，请稍后重试
        /// </summary>
        [Description("异常，请稍后重试")]
        HandleException = 101,

        /// <summary>
        /// 验证码过期
        /// </summary>
        [Description("验证码过期")]
        HandleExpired = 102,

        /// <summary>
        /// 验证码错误
        /// </summary>
        [Description("验证码错误")]
        HandleCheckError = 103,
    }
}
