using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COR
{
    public class TeamLead : EmployeeLeaveHandler
    {
        private readonly int MAX_LEAVES_CAN_APPROVE = 10;
        public override void ApplyLeave(string EmployeeName, int NumberOfDays)
        {
            if(NumberOfDays <= MAX_LEAVES_CAN_APPROVE)
            {
                Console.WriteLine($"Team Lead approved {NumberOfDays} days leave for {EmployeeName}");
            }
            else
            {
                Supervisor.ApplyLeave(EmployeeName, NumberOfDays);
            }
        }
    }
}
