using System.Web.Mvc;

namespace MusicAndVocabulary.Areas.WebSystem
{
    public class WebSystemAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "WebSystem";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "WebSystem_default",
                "WebSystem/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new string[] { "MusicAndVocabulary.Areas.WebSystem.Controllers" }
            );
        }
    }
}