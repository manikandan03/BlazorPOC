using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ResearchTeamMember
    {
        public int Id { get; set; }
        public int ResearchDetailId { get; set; }
        public int? UserId { get; set; }
        public int? TeamHead { get; set; }
        public int? AdminId { get; set; }
        public int? TechnologyId { get; set; }
        public DateTime? ScheduledStartDate { get; set; }
        public DateTime? ScheduledEndDate { get; set; }
        public bool IsActive { get; set; }
    }
}
