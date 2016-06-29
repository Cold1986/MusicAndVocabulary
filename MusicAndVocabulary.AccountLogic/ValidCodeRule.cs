using Cold.CommonLibrary;
using MusicAndVocabulary.Entity;
using MusicAndVocabulary.Enum;
using MusicAndVocabulary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAndVocabulary.Implement
{
    /// <summary>
    /// 验证码业务类
    /// </summary>
    public class ValidCodeRule : IValidCodeRule
    {
        private const string validKey = "coldValid";
        private CommonResponse<string> _commonResult;

        public ValidCodeRule()
        {
            _commonResult = new CommonResponse<string>()
            {
                Messages = EnumHelper.GetDesc(EnumValidCode.HandleException),
                Succeeded = false
            };
        }

        /// <summary>
        /// 校验验证码
        /// </summary>
        /// <param name="InputCode">传入值</param>
        /// <returns></returns>
        public CommonResponse<string> CheckValidCode(string InputCode)
        {
            var cookieCode = CookieHelper.GetCookieValue("validCode");
            if (string.IsNullOrEmpty(cookieCode))
            {
                _commonResult.Messages = EnumHelper.GetDesc(EnumValidCode.HandleExpired);
            }
            else
            {
                var inputCodeMd5 = MD5Encrypt.GetStrMD5(InputCode + validKey);
                if (inputCodeMd5 != cookieCode)
                {
                    _commonResult.Messages = EnumHelper.GetDesc(EnumValidCode.HandleCheckError);
                }
                else
                {
                    _commonResult.Succeeded = true;
                    _commonResult.Messages = null;
                }
            }

            return _commonResult;
        }

        /// <summary>
        /// 创建验证码
        /// </summary>
        /// <returns></returns>
        public string CreateNewValidCode()
        {
            var validCode = RandomHelper.Str(6, true);
            CookieHelper.ClearCookie("validCode");
            CookieHelper.SetCookie("validCode", MD5Encrypt.GetStrMD5(validCode + validKey), 20 * 60 * 1000);

            var imgBase64 = VerifyCodeHelper.CreateCheckCodeImage(validCode);

            return imgBase64;
        }
    }
}
