using Cold.CommonLibrary;
using MusicAndVocabulary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace MusicAndVocabulary.Implement
{
    public class ServiceRule: IServiceRule
    {
        public void ClearSessionAndCookie()
        {
            SessionHelper.Abandon();
            FormsAuthentication.SignOut();
            CookieHelper.ClearCookie(FormsAuthentication.FormsCookieName);
        }

        public void SetFormsAuthenticationTicket(int version,string name,DateTime issueDate,DateTime expiration,bool isPersistent,string userData)
        {
            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(version, name, issueDate, expiration
                        , isPersistent, userData);
            string hashTicket = FormsAuthentication.Encrypt(ticket);
            CookieHelper.SetCookie(FormsAuthentication.FormsCookieName, hashTicket);
        }
    }
}
