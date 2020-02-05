using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class UserRoles
    {
        public long UserRoleId { get; set; }
        public int UserId { get; set; }
        public byte RoleId { get; set; }

        public virtual MasterRoles Role { get; set; }
        public virtual Users User { get; set; }
    }
}
