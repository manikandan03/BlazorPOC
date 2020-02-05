using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class UserReporting
    {
        public int ReportingId { get; set; }
        public int UserId { get; set; }
        public int? ReportingUserId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? IsActive { get; set; }

        public virtual Users User { get; set; }
    }
}
