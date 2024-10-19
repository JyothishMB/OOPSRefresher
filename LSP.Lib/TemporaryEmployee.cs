using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Lib
{
    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee()
        {

        }
        public TemporaryEmployee(int Id, string Name) : base(Id, Name)
        {

        }
        public override decimal CalculateBonus(decimal Salary)
        {
            return Salary * .05M;
        }

        public override decimal GetMinimumSalary()
        {
            return 10000;
        }
    }
}
