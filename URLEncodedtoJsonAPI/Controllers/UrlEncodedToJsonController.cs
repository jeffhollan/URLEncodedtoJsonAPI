using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using System.Text;
using System.Globalization;
using System.Net;
using System.Web;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using System.Collections.Specialized;

namespace URLEncodedtoJsonAPI.Controllers
{
    public class UrlEncodedToJsonController : ApiController
    {
        public HttpResponseMessage UrlEncodedToJson([FromUri] string urlEncodedString)
        {
            var formData = HttpUtility.ParseQueryString(urlEncodedString);
            var dict = new Dictionary<string, string>();
            foreach(string key in formData)
            {
                dict.Add(key, formData[key]);
            }
            return Request.CreateResponse(dict);
        }
    }
}

