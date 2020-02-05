using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class Reports
    {
        public int ReportId { get; set; }
        public string ReportName { get; set; }
        public string ReportQuery { get; set; }
        public bool? IsActive { get; set; }
    }
}
