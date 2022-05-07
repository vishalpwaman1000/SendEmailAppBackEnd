using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SendEmailApllicationBE.Model;
using SendEmailApllicationBE.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SendEmailApllicationBE.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class SendEmailController : ControllerBase
    {
        public readonly ISendEmailSL _sendEmailSL;
        public SendEmailController(ISendEmailSL sendEmailSL)
        {
            _sendEmailSL = sendEmailSL;
        }

        [HttpPost]
        public async Task<IActionResult> SendEmailAPI(SendEmailAPIRequest request)
        {
            SendEmailAPIResponse response = new SendEmailAPIResponse();

            try
            {

                response = await _sendEmailSL.SendEmailAPI(request);
            }
            catch(Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Occurs : " + ex.Message;
            }

            return Ok(response);
        }

    }
}
