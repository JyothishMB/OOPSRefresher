using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COR
{
    public class LeaveManager
    {
        private TeamLead teamLead = new TeamLead();
        private ProjectLead projectLead = new ProjectLead();
        private HR hr = new HR();

        public LeaveManager()
        {
            teamLead.SetNextSupervisor(projectLead);
            projectLead.SetNextSupervisor(hr);
        }

        public void ApplyLeave(string EmployeeName, int NumberOfDays)
        {
            teamLead.ApplyLeave(EmployeeName, NumberOfDays);
        }
    }
}
