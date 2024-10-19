
using Prototype.Demo.Console.Classes;

Employee emp1 = new PermanentEmployee()
{
    Id = Guid.NewGuid(),
    Name = "John",
    Department = "IT",
    Salary = 50000
};

Employee emp2 = emp1.GetClone();
emp2.Id = Guid.NewGuid();
emp2.Name = "Jim";
emp2.Department = "Sales";

emp1.Print();
emp2.Print();

Employee emp3 = new TemporaryEmployee()
{
    Id = Guid.NewGuid(),
    Name = "Jane",
    Department = "HR",
    Days = 10,
    PaymentPerDay = 2500
};

Employee emp4 = emp3.GetClone();
emp4.Id = Guid.NewGuid();
emp4.Name = "Jake";
emp4.Department = "Finance";

emp3.Print();
emp4.Print();


Console.ReadKey();






