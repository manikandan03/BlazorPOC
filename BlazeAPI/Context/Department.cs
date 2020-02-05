using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class Department
    {
        public Department()
        {
            DepartmentGroupMapping = new HashSet<DepartmentGroupMapping>();
            QuickEnroll = new HashSet<QuickEnroll>();
            Users = new HashSet<Users>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public bool? IsActive { get; set; }
        public int? BranchId { get; set; }
        public bool? UnderDevelopment { get; set; }

        public virtual ICollection<DepartmentGroupMapping> DepartmentGroupMapping { get; set; }
        public virtual ICollection<QuickEnroll> QuickEnroll { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
