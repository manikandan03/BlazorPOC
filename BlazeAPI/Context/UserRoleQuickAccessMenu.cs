using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class UserRoleQuickAccessMenu
    {
        public int UserRoleQuickAccessMenuId { get; set; }
        public int? QuickAccessMenuId { get; set; }
        public byte? RoleId { get; set; }

        public virtual QuickAccessMenu QuickAccessMenu { get; set; }
        public virtual MasterRoles Role { get; set; }
    }
}
