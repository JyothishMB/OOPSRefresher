using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Demo
{
    public abstract class AbstractMessage
    {
        protected IMessageSender sender;
        public abstract void SendMessage(string Message);
    }
}
