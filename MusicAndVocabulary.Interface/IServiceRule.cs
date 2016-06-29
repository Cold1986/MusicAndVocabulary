using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAndVocabulary.Interface
{
    public interface IServiceRule
    {
        void ClearSessionAndCookie();

        void SetFormsAuthenticationTicket(int version, string name, DateTime issueDate, DateTime expiration, bool isPersistent, string userData);
    }
}
