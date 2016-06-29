using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicAndVocabulary.Controllers
{
    public class AbstractController : Controller
    {
        [HttpPost]
        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            base.Initialize(requestContext);
            ViewBag.BasePath = basePath;

        }

        /// <summary>得到网站基础url</summary>
        public string basePath
        {
            get
            {
                return string.Format("{0}/", Request.ApplicationPath.TrimEnd('/'));
            }
        }
    }
}