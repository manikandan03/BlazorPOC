using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class IncidentDepartment
    {
        public IncidentDepartment()
        {
            IncidentManagementHistory = new HashSet<IncidentManagementHistory>();
        }

        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public int? RepId { get; set; }

        public virtual ICollection<IncidentManagementHistory> IncidentManagementHistory { get; set; }
    }
}
