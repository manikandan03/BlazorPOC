using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class DefaultModulePrecedanceOrder
    {
        public int SubPreceedingId { get; set; }
        public byte PageModuleId { get; set; }
        public int PreceedanceOrder { get; set; }
    }
}
