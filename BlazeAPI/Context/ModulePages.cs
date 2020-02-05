using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ModulePages
    {
        public int ModulePageId { get; set; }
        public byte PageModuleId { get; set; }
        public int PageId { get; set; }

        public virtual Pages Page { get; set; }
        public virtual Modules PageModule { get; set; }
    }
}
