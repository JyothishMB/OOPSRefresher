using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Demo
{
    public class SMSMessageSender : IMessageSender
    {
        public void SendMessage(string Message)
        {
            Console.WriteLine("SMS Sent. Message -> " + Message);
        }
    }
}
