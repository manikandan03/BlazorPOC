using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ExceptionLog
    {
        public int ExceptionLogId { get; set; }
        public long UserId { get; set; }
        public DateTime ExceptionDate { get; set; }
        public string ExceptionMessage { get; set; }
        public string Source { get; set; }
        public string MethodName { get; set; }
        public string StackTrace { get; set; }
    }
}
