using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class RoleFunctionPrivileges
    {
        public int RoleFunctionPrivilegeId { get; set; }
        public byte? RoleId { get; set; }
        public byte? FunctionId { get; set; }
        public byte? PageModuleId { get; set; }
        public bool? CanRead { get; set; }
        public bool? CanWrite { get; set; }
        public bool? CanDelete { get; set; }

        public virtual Functions Function { get; set; }
        public virtual Modules PageModule { get; set; }
        public virtual MasterRoles Role { get; set; }
    }
}
