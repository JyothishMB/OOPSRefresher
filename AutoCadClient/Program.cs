// See https://aka.ms/new-console-template for more information
using AutoCard.Stamper;

Console.WriteLine("Hello, World!");

ITarget target = new AutoCadAdapter();
target.StampDocument("C://Drawing//Building.dwg", "JMB|Jyothish|Engineer");
Console.ReadKey();
