using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class IncidentManagementHistory
    {
        public int HistoryId { get; set; }
        public int IncidentId { get; set; }
        public int ResponsibleDepartmentId { get; set; }
        public int ReportingId { get; set; }
        public int Status { get; set; }
        public int? Priority { get; set; }
        public int? Severity { get; set; }
        public bool? IsEscalation { get; set; }
        public string ResolutionTaken { get; set; }
        public string ImpactOccured { get; set; }
        public DateTime? ProcessedDate { get; set; }
        public int? ReassignedBy { get; set; }
        public int? PreviousDepartmentId { get; set; }
        public DateTime? ReassignedDate { get; set; }

        public virtual IncidentManagement Incident { get; set; }
        public virtual IncidentDepartment ResponsibleDepartment { get; set; }
    }
}
