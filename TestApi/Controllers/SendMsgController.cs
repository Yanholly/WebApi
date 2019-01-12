using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NPushover;
namespace TestApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SendMsgController : ControllerBase
    {   
        // POST api/values
        [HttpPost]
        public void Post([FromBody] Models.MessageInfo value)
        {
            var po = new Pushover(value.app_token);
            var msg = NPushover.RequestObjects.Message.Create(value.msg_text);
            var sendtask = po.SendMessageAsync(msg, value.user_key);
        }
    }
}
