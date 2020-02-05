using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class DepartmentGroupMapping
    {
        public int GroupMappingId { get; set; }
        public int? GroupId { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual DepartmentGroup Group { get; set; }
    }
}
