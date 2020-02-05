using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ProjectMetrics
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? Date { get; set; }
        public string Metrics { get; set; }
    }
}
