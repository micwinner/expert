using System;

namespace instrument.expert.web.Models
{
    public class BaseResult
    {
        public int Code { get; set; }
        public string Msg { get; set; }
        public object Result { get; set; }
        public Exception Exp { get; set; }
    }
}