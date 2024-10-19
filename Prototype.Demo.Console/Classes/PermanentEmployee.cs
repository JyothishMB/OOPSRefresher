using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Demo.Console.Classes
{
    public class PermanentEmployee : Employee
    {
        public long Salary { get; set; }
        public override Employee GetClone()
        {
            return (PermanentEmployee)this.MemberwiseClone();
        }

        public override void Print()
        {
            System.Console.WriteLine($"Employee Details\n-------------------------------\nId -> {this.Id}\nName -> {this.Name}\nDepartment -> {this.Department}\nSalary -> {this.Salary}");
        }
    }
}
