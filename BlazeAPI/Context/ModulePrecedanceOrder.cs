using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ModulePrecedanceOrder
    {
        public int SubPreceedingId { get; set; }
        public byte RoleId { get; set; }
        public byte PageModuleId { get; set; }
        public int PreceedanceOrder { get; set; }

        public virtual Modules PageModule { get; set; }
        public virtual MasterRoles Role { get; set; }
    }
}
