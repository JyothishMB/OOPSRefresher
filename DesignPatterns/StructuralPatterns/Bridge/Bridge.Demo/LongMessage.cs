using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Demo
{
    public class LongMessage : AbstractMessage
    {
        public LongMessage(IMessageSender sender)
        {
            this.sender = sender;
        }
        public override void SendMessage(string Message)
        {
            sender.SendMessage(Message);
        }
    }
}
