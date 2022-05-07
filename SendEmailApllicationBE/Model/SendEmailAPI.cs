using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SendEmailApllicationBE.Model
{
    public class SendEmailAPIRequest
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }

    public class SendEmailAPIResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
