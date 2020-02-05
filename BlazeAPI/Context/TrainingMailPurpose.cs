using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class TrainingMailPurpose
    {
        public int TrainingId { get; set; }
        public string TrainingName { get; set; }
        public int? TechnologyId { get; set; }
        public DateTime? InitiatedOn { get; set; }
        public DateTime? ScheduledDate { get; set; }
        public bool? IsActive { get; set; }
        public int? InstructorId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public bool? GroupEmailFlag { get; set; }
        public DateTime? ScheduledEndDate { get; set; }

        public virtual MasterTrainingTechnology Technology { get; set; }
    }
}
