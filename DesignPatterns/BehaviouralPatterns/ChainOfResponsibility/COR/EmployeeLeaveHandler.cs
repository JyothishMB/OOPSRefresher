using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COR
{
    public abstract class EmployeeLeaveHandler
    {
        protected EmployeeLeaveHandler Supervisor;

        public void SetNextSupervisor(EmployeeLeaveHandler Supervisor)
        {
            this.Supervisor = Supervisor;
        }
        public abstract void ApplyLeave(string EmployeeName, int NumberOfDays);
    }
}
