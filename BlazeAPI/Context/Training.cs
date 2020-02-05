using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class Training
    {
        public Training()
        {
            Trainingabsenteesreason = new HashSet<Trainingabsenteesreason>();
        }

        public int TrainingId { get; set; }
        public string TrainingName { get; set; }
        public int TrainingTypeId { get; set; }
        public int? LevelId { get; set; }
        public int? TechnologyId { get; set; }
        public DateTime? InitiatedOn { get; set; }
        public string InitiatedBy { get; set; }
        public DateTime? ScheduledDate { get; set; }
        public int? StatusId { get; set; }
        public int? NumberOfNominated { get; set; }
        public int? NumberOfAttendence { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? RecheduledDate { get; set; }
        public string Repository { get; set; }
        public int? InstructorId { get; set; }
        public int? SeatingCapacity { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public bool? Flag { get; set; }
        public int? Roleid { get; set; }
        public string MailDepartments { get; set; }
        public string NotifyUsers { get; set; }
        public DateTime? ScheduledEndDate { get; set; }

        public virtual MasterTrainingLevel Level { get; set; }
        public virtual MasterTrainingStatus Status { get; set; }
        public virtual MasterTrainingTechnology Technology { get; set; }
        public virtual MasterTrainingType TrainingType { get; set; }
        public virtual ICollection<Trainingabsenteesreason> Trainingabsenteesreason { get; set; }
    }
}
