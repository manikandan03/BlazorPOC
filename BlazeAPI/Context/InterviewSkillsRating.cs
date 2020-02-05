using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class InterviewSkillsRating
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int TechnologyId { get; set; }
        public int? Specialization { get; set; }
        public int Level { get; set; }
        public bool? Isactive { get; set; }
        public string Experiance { get; set; }
        public int? Rating { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string AnyCertifications { get; set; }

        public virtual SkillsSpecification SpecializationNavigation { get; set; }
        public virtual SkillsTechnology Technology { get; set; }
    }
}
