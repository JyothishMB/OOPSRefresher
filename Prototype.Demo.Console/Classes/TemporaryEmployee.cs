using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Demo.Console.Classes
{
    public class TemporaryEmployee : Employee
    {
        public long PaymentPerDay { get; set; }
        public int Days { get; set; }
        public override Employee GetClone()
        {
            return (TemporaryEmployee)this.MemberwiseClone();
        }

        public override void Print()
        {
            System.Console.WriteLine($"Employee Details\n-------------------------------\nId -> {this.Id}\nName -> {this.Name}\nDepartment -> {this.Department}\nSalary -> {this.PaymentPerDay*this.Days}");
        }
    }
}
