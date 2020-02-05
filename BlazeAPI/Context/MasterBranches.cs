using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterBranches
    {
        public MasterBranches()
        {
            QuickEnroll = new HashSet<QuickEnroll>();
        }

        public int BranchId { get; set; }
        public string BranchName { get; set; }

        public virtual ICollection<QuickEnroll> QuickEnroll { get; set; }
    }
}
