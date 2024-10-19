// See https://aka.ms/new-console-template for more information
using Observer.Lib;

Console.WriteLine("Hello, World!");

Subject monthlyProgressReport = new Subject("Monthly - Progress", "Jyothish", false);

Observer.Lib.Observer employee1 = new Observer.Lib.Observer("John");
employee1.Subscribe(monthlyProgressReport);

Observer.Lib.Observer employee2 = new Observer.Lib.Observer("David");
employee2.Subscribe(monthlyProgressReport);

Observer.Lib.Observer employee3 = new Observer.Lib.Observer("Harris");
employee3.Subscribe(monthlyProgressReport);


monthlyProgressReport.MakeReady(true);

Console.ReadKey();

