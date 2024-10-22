using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COR
{
    public class HR : EmployeeLeaveHandler
    {
        private readonly int MAX_LEAVES_CAN_APPROVE = 30;
        public override void ApplyLeave(string EmployeeName, int NumberOfDays)
        {
            if (NumberOfDays <= MAX_LEAVES_CAN_APPROVE)
            {
                Console.WriteLine($"HR approved {NumberOfDays} days leave for {EmployeeName}");
            }
            else
            {
                Console.WriteLine($"Leave application suspended for Employee {EmployeeName}, Please contact HR");
            }
        }
    }
}
