using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class FunctionModules
    {
        public int FunctionModuleId { get; set; }
        public byte FunctionId { get; set; }
        public byte PageModuleId { get; set; }

        public virtual Functions Function { get; set; }
        public virtual Modules PageModule { get; set; }
    }
}
