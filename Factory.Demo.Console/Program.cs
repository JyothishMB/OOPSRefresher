// See https://aka.ms/new-console-template for more information
using Factory;

Console.WriteLine("Hello, World!");

string userInput = string.Empty;
Console.WriteLine("Enter vehicle type");
userInput = Console.ReadLine();
IVehicle vehicle = VehicleFactory.Create(userInput);
Console.WriteLine("Vehicle type : "+vehicle.GetVehicleType());
Console.WriteLine("Number of wheels : "+vehicle.GetNumberOfWheels());
Console.ReadKey();
