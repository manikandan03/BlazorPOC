using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class EmployeeGoalProgress
    {
        public int EmployeeGoalProgress1 { get; set; }
        public int EmployeeGoalId { get; set; }
        public int? GoalProgress { get; set; }
        public string GoalComments { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual EmployeeGoals EmployeeGoal { get; set; }
    }
}
