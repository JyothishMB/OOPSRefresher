// See https://aka.ms/new-console-template for more information
using LSP.Lib;
using LSP.Lib.Interfaces;

Console.WriteLine("LSP Demo");


List<Employee> employees = new List<Employee>();
employees.Add(new PermanentEmployee(1,"John"));
employees.Add(new TemporaryEmployee(2, "Jacob"));
//employees.Add(new ContractEmployee());

foreach (Employee employee in employees)
{
    Console.WriteLine($"\nEmployee: {employee.ToString()} Salary: {employee.GetMinimumSalary()} Bonus: {employee.CalculateBonus(10000)}");
}


List<IEmployee> employees1 = new List<IEmployee>();
employees1.Add(new PermanentEmployee(1, "John"));
employees1.Add(new TemporaryEmployee(2, "Jacob"));
employees1.Add(new ContractEmployee(3, "James"));

foreach (var employee in employees1)
{
    Console.WriteLine($"\nEmployee: {employee.ToString()} Salary: {employee.GetMinimumSalary()}");
}


