using MusicAndVocabulary.Implement;
using MusicAndVocabulary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace MusicAndVocabulary.WebApi.Controllers
{
    public class ValidCodeController : ApiController
    {
        IValidCodeRule validCodeBiz = new ValidCodeRule();
        public Task<string> GetBase64ValidCodeImg()
        {
            //var result = Task.Factory.StartNew(() => { validCodeBiz.CreateNewValidCode(); });
            //return result;
            return null;
        }
    }
}
