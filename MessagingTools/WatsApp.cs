using Messaging.Lib.Interfaces;

namespace MessagingTools
{
    public class WatsApp : IMessenger
    {
        public void AddRecipient(string recipientAddress)
        {
            Console.WriteLine("Added WatsApp Recipient");
        }

        public void CreateMessage(string messageText)
        {
            Console.WriteLine("Created WatsApp Message");
        }

        public void Send()
        {
            Console.WriteLine("WatsApp Message Sent.");
        }
    }
}
