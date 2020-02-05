using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class UserTask
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int TaskSource { get; set; }
        public string TaskId { get; set; }
        public string Description { get; set; }
        public int EnteredBy { get; set; }
        public int? Hour { get; set; }
        public int? Minute { get; set; }
        public bool? Isactive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? Status { get; set; }
        public int? ReportingId { get; set; }
        public bool? Sendforapproval { get; set; }
        public bool? SendForReporting { get; set; }
        public DateTime? Date { get; set; }
        public int? Odid { get; set; }

        public virtual OutOfOfficeDetails Od { get; set; }
    }
}
