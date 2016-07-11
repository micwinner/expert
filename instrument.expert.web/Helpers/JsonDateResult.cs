using System;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace instrument.expert.web.Helpers
{
    public class JsonDateResult : JsonResult
    {
        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }
            if ((JsonRequestBehavior == JsonRequestBehavior.DenyGet) &&
                string.Equals(context.HttpContext.Request.HttpMethod, "GET", StringComparison.OrdinalIgnoreCase))
            {
                throw new InvalidOperationException("neek set get method");
            }
            var response = context.HttpContext.Response;
            response.ContentType = !string.IsNullOrEmpty(ContentType) ? ContentType : "application/json";
            if (ContentEncoding != null)
            {
                response.ContentEncoding = ContentEncoding;
            }
            if (Data == null) return;
            var timeFormat = new IsoDateTimeConverter {DateTimeFormat = "yyyy-MM-dd"};
            response.Write(JsonConvert.SerializeObject(Data, Formatting.Indented, timeFormat));
        }
    }
}