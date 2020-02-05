using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class EmailPurposeLog
    {
        public int LogId { get; set; }
        public int EmailPurposeId { get; set; }
        public string ParameterChanges { get; set; }
        public string Content { get; set; }
        public int UpdatedUserId { get; set; }
        public DateTime Datetimestamp { get; set; }
        public bool IsActive { get; set; }
    }
}
