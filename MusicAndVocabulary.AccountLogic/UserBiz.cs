using Cold.CommonLibrary;
using MusicAndVocabulary.Entity;
using MusicAndVocabulary.Enum;
using MusicAndVocabulary.Interface;
using MusicAndVocabulary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAndVocabulary.Implement
{
    public class UserBiz : IUserBiz
    {
        private UserResponse<string> _authorityResponse;
        private MusicAndVocabularyEntities db = new MusicAndVocabularyEntities();

        public UserBiz()
        {
            _authorityResponse = new UserResponse<string>
            {
                Succeeded = false,
                Messages = EnumHelper.GetDesc(EnumUser.HandleException),
                Userinfo = null
            };
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public UserResponse<string> MatchAccount(string UserName, string Password)
        {
            var user = db.Users.SingleOrDefault(u => u.UserName == UserName && u.Password == Password);
            if (user != null)
            {
                _authorityResponse.Succeeded = true;
                _authorityResponse.Userinfo = user;
                _authorityResponse.Messages = EnumHelper.GetDesc(EnumUser.HandleCheckSuccess);
            }
            else
            {
                _authorityResponse.Messages = EnumHelper.GetDesc(EnumUser.HandleUserNameOrPsdError);
            }
            return _authorityResponse;
        }
    }
}
