using Messaging.Lib;
using MessagingTools.ConcreteFactory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly Factory factory;

        public MessageController(Factory factory)
        {
            this.factory = factory;
        }

        [HttpPost]
        public async Task<string> SendMessage(string message)
        {
            var smsapp = factory.CreateMessengerApp();
            smsapp.CreateMessage(message);
            smsapp.AddRecipient("+911111223344");
            smsapp.Send();
            return "Success";
        }
    }
}
