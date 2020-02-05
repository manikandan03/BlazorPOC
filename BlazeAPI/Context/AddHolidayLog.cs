using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class AddHolidayLog
    {
        public int AuditId { get; set; }
        public int TableId { get; set; }
        public string ColumnChanged { get; set; }
        public string PeviousValue { get; set; }
        public string CurrentValue { get; set; }
        public int ChangedBy { get; set; }
        public DateTime? Date { get; set; }
    }
}
