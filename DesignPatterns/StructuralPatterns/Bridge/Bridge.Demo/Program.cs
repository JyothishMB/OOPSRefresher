using Bridge.Demo;

Console.WriteLine("Select the Message Type \n 1. For long message \n 2. For shortmessage");
int MessageType = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the message that you want to send");
string Message = Console.ReadLine();
if (MessageType == 1)
{
    AbstractMessage longMessage = new LongMessage(new EmailMessageSender());
    longMessage.SendMessage(Message);
}
else
{
    AbstractMessage shortMessage = new ShortMessage(new SMSMessageSender());
    shortMessage.SendMessage(Message);
}
Console.ReadKey();