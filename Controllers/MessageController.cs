using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

namespace Microsoft.Azure.SignalR.Samples.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        public MessageController()
        {
        }

        [HttpPost()]
        public void Post()
        {
            // Globals.ChatHub.Clients.All.SendCoreAsync("BroadcastMessage", new object[] { "__SERVER__", "(echo from server)" });
        }
    }
}