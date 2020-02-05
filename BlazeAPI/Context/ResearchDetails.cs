using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ResearchDetails
    {
        public int Id { get; set; }
        public string ResearchTopic { get; set; }
        public string Description { get; set; }
        public int? DepartmentId { get; set; }
        public int? ResearchTypeId { get; set; }
        public int? TechnologyId { get; set; }
        public int? AdminId { get; set; }
        public int? TeamHead { get; set; }
        public int? TeamSize { get; set; }
        public DateTime? ScheduledStartDate { get; set; }
        public DateTime? ScheduledEndDate { get; set; }
        public bool IsActive { get; set; }
    }
}
