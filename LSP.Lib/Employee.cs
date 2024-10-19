using LSP.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Lib
{
    public abstract class Employee : IEmployee, IEmployeeBonus
    {
        public int ID { get; set; }
        public string Name { get; set; }

        protected Employee()
        {
            
        }
        protected Employee(int Id, string name)
        {
            ID = Id;
            Name = name;
        }

        public abstract decimal CalculateBonus(decimal Salary);
        public abstract decimal GetMinimumSalary();
        public string ToString()
        {
            return $"ID: {ID} Name: {Name}";
        }
    }
}
