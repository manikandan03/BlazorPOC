using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class Skills
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int Technology { get; set; }
        public int? Specialization { get; set; }
        public int Level { get; set; }
        public bool? Primary { get; set; }
        public bool? Secondary { get; set; }
        public DateTime? Date { get; set; }
        public int? LastUsed { get; set; }
        public bool? Isactive { get; set; }
        public string Experiance { get; set; }
        public int? Status { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string RejectedReason { get; set; }
        public string AnyCertifications { get; set; }

        public virtual SkillsSpecification SpecializationNavigation { get; set; }
    }
}
