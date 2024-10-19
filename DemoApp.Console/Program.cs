// See https://aka.ms/new-console-template for more information
using MessagingTools.ConcreteFactory;

Console.WriteLine("Messaging Initiated");
Console.WriteLine("Options");
Console.WriteLine("-------------------");
Console.WriteLine("1. SMS");
Console.WriteLine("2. Email");
Console.WriteLine("3. WatsApp");
Console.WriteLine("Enter your choice > ");
var choice = Console.ReadLine();

switch(Convert.ToInt32(choice))
{
    case 1: 
            Console.WriteLine("Initiating SMS");
            var smsmessenger = new SMSFactory().CreateMessengerApp();
            smsmessenger.CreateMessage("This is a test SMS message");
            smsmessenger.AddRecipient("+911112223334");
            smsmessenger.Send();
            break;
    case 2: 
            Console.WriteLine("Initiating Email");
            var emailmessenger = new EmailFactory().CreateMessengerApp();
            emailmessenger.CreateMessage("This is a test Email message");
            emailmessenger.AddRecipient("jyothish@gmail.com");
            emailmessenger.Send();
            break;
    case 3: 
            Console.WriteLine("Initiating WatsApp");
            var watsAppFactory = new WatsAppFactory().CreateMessengerApp();
            watsAppFactory.CreateMessage("This is a test WatsApp message");
            watsAppFactory.AddRecipient("+911112223335");
            watsAppFactory.Send();
            break;
    default: 
            Console.WriteLine("Wrong choice"); break;
}

Console.ReadKey();


