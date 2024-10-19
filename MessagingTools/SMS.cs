using Messaging.Lib.Interfaces;

namespace MessagingTools
{
    public class SMS : IMessenger
    {
        public void AddRecipient(string recipientAddress)
        {
            Console.WriteLine("Added SMS Recipient");
        }

        public void CreateMessage(string messageText)
        {
            Console.WriteLine("Created SMS Message");
        }

        public void Send()
        {
            Console.WriteLine("SMS Message Sent.");
        }
    }
}
