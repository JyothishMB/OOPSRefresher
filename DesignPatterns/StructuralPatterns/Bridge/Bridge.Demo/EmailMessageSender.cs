using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Demo
{
    public class EmailMessageSender : IMessageSender
    {
        public void SendMessage(string Message)
        {
            Console.WriteLine("Email Sent. Message -> " + Message);
        }
    }
}
