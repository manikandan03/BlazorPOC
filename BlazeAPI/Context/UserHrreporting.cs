using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class UserHrreporting
    {
        public int Hrid { get; set; }
        public int UserId { get; set; }
        public int? ReportingHrid { get; set; }

        public virtual Users User { get; set; }
    }
}
