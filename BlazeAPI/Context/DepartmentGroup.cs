using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class DepartmentGroup
    {
        public DepartmentGroup()
        {
            DepartmentGroupMapping = new HashSet<DepartmentGroupMapping>();
            QuickEnroll = new HashSet<QuickEnroll>();
        }

        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<DepartmentGroupMapping> DepartmentGroupMapping { get; set; }
        public virtual ICollection<QuickEnroll> QuickEnroll { get; set; }
    }
}
