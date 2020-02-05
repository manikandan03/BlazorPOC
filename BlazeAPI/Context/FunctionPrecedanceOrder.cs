using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class FunctionPrecedanceOrder
    {
        public int PreceedingId { get; set; }
        public byte RoleId { get; set; }
        public byte FunctionId { get; set; }
        public int PreceedanceOrder { get; set; }

        public virtual Functions Function { get; set; }
        public virtual MasterRoles Role { get; set; }
    }
}
