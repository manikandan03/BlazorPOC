using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class SkillsSpecification
    {
        public SkillsSpecification()
        {
            InterviewSkillsRating = new HashSet<InterviewSkillsRating>();
            SkillSpecificationMapping = new HashSet<SkillSpecificationMapping>();
            Skills = new HashSet<Skills>();
        }

        public int SpecificationId { get; set; }
        public string Specification { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<InterviewSkillsRating> InterviewSkillsRating { get; set; }
        public virtual ICollection<SkillSpecificationMapping> SkillSpecificationMapping { get; set; }
        public virtual ICollection<Skills> Skills { get; set; }
    }
}
