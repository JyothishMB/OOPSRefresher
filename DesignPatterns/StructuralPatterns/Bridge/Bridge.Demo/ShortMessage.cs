using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Demo
{
    public class ShortMessage : AbstractMessage
    {
        public ShortMessage(IMessageSender sender)
        {
            this.sender = sender;
        }
        public override void SendMessage(string Message)
        {
            if(Message.Length <= 10)
            {
                sender.SendMessage(Message);
            }
            else
            {
                Console.WriteLine("Unable to send message as length > 10 chars");
            }
        }
    }
}
