using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class RoleFunctions
    {
        public int RoleFunctionId { get; set; }
        public byte RoleId { get; set; }
        public byte FunctionId { get; set; }

        public virtual Functions Function { get; set; }
        public virtual MasterRoles Role { get; set; }
    }
}
