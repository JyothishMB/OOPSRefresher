using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COR
{
    public class ProjectLead : EmployeeLeaveHandler
    {
        private readonly int MAX_LEAVES_CAN_APPROVE = 20;
        public override void ApplyLeave(string EmployeeName, int NumberOfDays)
        {
            if (NumberOfDays <= MAX_LEAVES_CAN_APPROVE)
            {
                Console.WriteLine($"Project Lead approved {NumberOfDays} days leave for {EmployeeName}");
            }
            else
            {
                Supervisor.ApplyLeave(EmployeeName, NumberOfDays);
            }
        }
    }
}
