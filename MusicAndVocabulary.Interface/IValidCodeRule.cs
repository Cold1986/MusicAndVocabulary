using MusicAndVocabulary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAndVocabulary.Interface
{
    /// <summary>
    /// 验证码接口
    /// </summary>
    public interface IValidCodeRule
    {
        /// <summary>
        /// 创建验证码
        /// </summary>
        /// <returns></returns>
        string CreateNewValidCode();

        /// <summary>
        /// 校验验证码
        /// </summary>
        /// <param name="InputCode">传入值</param>
        /// <returns></returns>
        CommonResponse<string> CheckValidCode(string InputCode);
    }
}
