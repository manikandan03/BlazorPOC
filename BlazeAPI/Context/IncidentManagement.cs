using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class IncidentManagement
    {
        public IncidentManagement()
        {
            IncidentManagementHistory = new HashSet<IncidentManagementHistory>();
        }

        public int IncidentId { get; set; }
        public int ReportedBy { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<IncidentManagementHistory> IncidentManagementHistory { get; set; }
    }
}
