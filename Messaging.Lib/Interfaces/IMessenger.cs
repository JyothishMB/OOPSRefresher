using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Lib.Interfaces
{
    public interface IMessenger
    {

        void CreateMessage(string messageText);
        void AddRecipient(string recipientAddress);
        void Send();
    }
}
