using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ProjectCategoryMapping
    {
        public int ProjectCategoryMappingId { get; set; }
        public int ProjectId { get; set; }
        public int? CategoryId { get; set; }
        public bool? IsActive { get; set; }

        public virtual Category Category { get; set; }
        public virtual Projects Project { get; set; }
    }
}
