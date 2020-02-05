using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class BackEndServiceErrorLog
    {
        public int BackEndServiceErrorLogId { get; set; }
        public int BackEndServiceLogId { get; set; }
        public string ExceptionMessage { get; set; }
        public DateTime Datetime { get; set; }
        public string Source { get; set; }
        public string MethodName { get; set; }
        public string StackTrace { get; set; }

        public virtual BackEndServiceLog BackEndServiceLog { get; set; }
    }
}
