using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Demo.Console.Classes
{
    public abstract class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        public abstract Employee GetClone();
        public abstract void Print();
    }
}
