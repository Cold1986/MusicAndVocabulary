using MusicAndVocabulary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAndVocabulary.Entity
{
    public class UserResponse<T> : CommonResponse<T>
    {
        public User Userinfo { get; set; }
    }
}
