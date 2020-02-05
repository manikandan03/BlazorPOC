using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class SkillSpecificationMapping
    {
        public int SkillSpecificationMappingId { get; set; }
        public int? SkillId { get; set; }
        public int? SpecificationId { get; set; }
        public bool IsActive { get; set; }

        public virtual SkillsTechnology Skill { get; set; }
        public virtual SkillsSpecification Specification { get; set; }
    }
}
