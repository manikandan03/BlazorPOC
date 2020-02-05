using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class UserProjects
    {
        public UserProjects()
        {
            RemoveRequest = new HashSet<RemoveRequest>();
        }

        public int UserProjectId { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public byte? RoleId { get; set; }
        public bool? IsBillable { get; set; }
        public int? MemberTypeId { get; set; }
        public DateTime? UserStartDate { get; set; }
        public DateTime? UserEndDate { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? UserAssignedEndDate { get; set; }
        public bool? IsCritical { get; set; }
        public int? ReplacementUserprojectId { get; set; }
        public int? ShaddowUserprojectId { get; set; }

        public virtual Projects Project { get; set; }
        public virtual MasterRoles Role { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<RemoveRequest> RemoveRequest { get; set; }
    }
}
