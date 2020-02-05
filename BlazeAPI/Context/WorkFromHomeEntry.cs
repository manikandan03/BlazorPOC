using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class WorkFromHomeEntry
    {
        public long Wfhid { get; set; }
        public int UserId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime RequestedDate { get; set; }
        public int EnteredBy { get; set; }
        public bool AlwaysAllowed { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Users EnteredByNavigation { get; set; }
        public virtual Users User { get; set; }
    }
}
