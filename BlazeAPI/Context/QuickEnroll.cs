using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class QuickEnroll
    {
        public int QuickEnroll1 { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public long? PhoneNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? IsActive { get; set; }
        public string Comments { get; set; }
        public DateTime? DateOfJoin { get; set; }
        public string Experience { get; set; }
        public string PersonalMailAddress { get; set; }
        public int? DepartmentId { get; set; }
        public int? DepartmentGroup { get; set; }
        public int? BranchId { get; set; }
        public int? GenderId { get; set; }
        public DateTime? DateOfEnquiry { get; set; }
        public int? RoleId { get; set; }

        public virtual MasterBranches Branch { get; set; }
        public virtual Department Department { get; set; }
        public virtual DepartmentGroup DepartmentGroupNavigation { get; set; }
        public virtual MasterGender Gender { get; set; }
        public virtual MasterDesignation Role { get; set; }
    }
}
