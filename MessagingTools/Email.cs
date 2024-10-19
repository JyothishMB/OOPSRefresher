using Messaging.Lib.Interfaces;

namespace MessagingTools
{
    public class Email : IMessenger
    {
        public void AddRecipient(string recipientAddress)
        {
            Console.WriteLine("Added Email Recipient");
        }

        public void CreateMessage(string messageText)
        {
            Console.WriteLine("Created Email Message");
        }

        public void Send()
        {
            Console.WriteLine("Email Message Sent.");
        }
    }
}
