using LSP.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Lib
{
    public class ContractEmployee : IEmployee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ContractEmployee()
        {

        }
        public ContractEmployee(int Id, string name)
        {
            ID = Id;
            Name = name;
        }
        public decimal GetMinimumSalary()
        {
            return 12000;
        }
        public string ToString()
        {
            return $"ID: {ID} Name: {Name}";
        }
    }
}
