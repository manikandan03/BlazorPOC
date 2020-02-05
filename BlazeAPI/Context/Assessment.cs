using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class Assessment
    {
        public int AssessmentId { get; set; }
        public string AssessmentName { get; set; }
        public string AssessmentDescription { get; set; }
        public DateTime? AssessmentDate { get; set; }
        public int? TotalScore { get; set; }
        public int? PassScore { get; set; }
        public int? BranchId { get; set; }
        public int? DepartmentId { get; set; }
        public int? GroupId { get; set; }
        public bool? IsActive { get; set; }
    }
}
