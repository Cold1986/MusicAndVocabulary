using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MusicAndVocabulary.Filter
{
    public class CheckLoginFilter: AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                if (filterContext.HttpContext.Session != null)
                {
                    string[] userNameAndPassWord =
                       ((FormsIdentity)filterContext.HttpContext.User.Identity).Ticket.UserData.Split('|');
                    var redirectToError = filterContext.ActionDescriptor.GetCustomAttributes(typeof(RedirectToErrorAttribute), true);
                }
            }
        }
    }
}