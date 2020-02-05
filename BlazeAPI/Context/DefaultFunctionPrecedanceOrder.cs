using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class DefaultFunctionPrecedanceOrder
    {
        public int PreceedingId { get; set; }
        public byte FunctionId { get; set; }
        public int PreceedanceOrder { get; set; }
    }
}
