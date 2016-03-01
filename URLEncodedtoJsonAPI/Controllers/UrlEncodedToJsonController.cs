using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using System.Web;

namespace URLEncodedtoJsonAPI.Controllers
{
    public class UrlEncodedToJsonController : ApiController
    {
        [Swashbuckle.Swagger.Annotations.SwaggerResponse(System.Net.HttpStatusCode.OK, "Twilio Message", typeof(TwilioResponse))]
        [HttpPost]
        public async System.Threading.Tasks.Task<HttpResponseMessage> UrlEncodedToJson(TwilioResponse twil)
        {
            //var response = await urlEncodedContent.ReadAsAsync<TwilioResponse>();
            return Request.CreateResponse(twil);
        }
    }

    public class TwilioResponse
    {
        public string ToCountry { get; set; }
        public string ToState { get; set; }
        public string SmsMessageSid { get; set; }
        public string NumMedia { get; set; }
        public string ToCity { get; set; }
        public string FromZip { get; set; }
        public string SmsSid { get; set; }
        public string FromState { get; set; }
        public string SmsStatus { get; set; }
        public string FromCity { get; set; }
        public string Body { get; set; }
        public string FromCountry { get; set; }
        public string To { get; set; }
        public string ToZip { get; set; }
        public string NumSegments { get; set; }
        public string MessageSid { get; set; }
        public string AccountSid { get; set; }
        public string From { get; set; }
        public string ApiVersion { get; set; }
    }
}

