using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class TeamLunchRequest
    {
        public int TlrequestId { get; set; }
        public int? RequestedUserId { get; set; }
        public string ProjectId { get; set; }
        public string TeamMembersId { get; set; }
        public DateTime? PlannedDate { get; set; }
        public DateTime? RequestedDate { get; set; }
        public int? ReportingUserId { get; set; }
        public DateTime? RescheduledDate { get; set; }
        public string Amount { get; set; }
        public string Comments { get; set; }
        public int? StatusId { get; set; }
    }
}
