using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class UserMarketingReporting
    {
        public int MarketingId { get; set; }
        public int UserId { get; set; }
        public int? ReportingMarketingId { get; set; }

        public virtual Users User { get; set; }
    }
}
