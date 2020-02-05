using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class AllEmpLeaveEntryPermission
    {
        public int AllEmpLeaveEntryPermissionId { get; set; }
        public int? UserId { get; set; }

        public virtual Users User { get; set; }
    }
}
