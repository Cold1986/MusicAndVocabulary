using MusicAndVocabulary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAndVocabulary.Interface
{
    public interface IUserBiz
    {
        UserResponse<string> MatchAccount(string UserName, string Password);
    }
}
