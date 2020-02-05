using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class SkillsTechnology
    {
        public SkillsTechnology()
        {
            InterviewSkillsRating = new HashSet<InterviewSkillsRating>();
            SkillSpecificationMapping = new HashSet<SkillSpecificationMapping>();
        }

        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<InterviewSkillsRating> InterviewSkillsRating { get; set; }
        public virtual ICollection<SkillSpecificationMapping> SkillSpecificationMapping { get; set; }
    }
}
