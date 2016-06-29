using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicAndVocabulary.Filter
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public class RedirectToErrorAttribute: Attribute
    {
    }
}