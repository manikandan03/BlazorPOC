using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class EmployeeGoals
    {
        public EmployeeGoals()
        {
            EmployeeGoalProgress = new HashSet<EmployeeGoalProgress>();
        }

        public int EmployeeGoalId { get; set; }
        public int UserId { get; set; }
        public int? ProjectId { get; set; }
        public string GoalName { get; set; }
        public string GoalDescription { get; set; }
        public DateTime GoalStartDate { get; set; }
        public DateTime GoalEndDate { get; set; }
        public int GoalSetByUserId { get; set; }
        public DateTime? GoalCreatedDate { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Users GoalSetByUser { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<EmployeeGoalProgress> EmployeeGoalProgress { get; set; }
    }
}
