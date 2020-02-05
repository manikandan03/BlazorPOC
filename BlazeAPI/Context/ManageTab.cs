using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ManageTab
    {
        public int ManageTabId { get; set; }
        public int? TabId { get; set; }
        public int? UserId { get; set; }
        public byte? RoleId { get; set; }
        public bool? IsActive { get; set; }
        public bool? UserSelected { get; set; }

        public virtual MasterRoles Role { get; set; }
        public virtual MasterTab Tab { get; set; }
        public virtual Users User { get; set; }
    }
}
