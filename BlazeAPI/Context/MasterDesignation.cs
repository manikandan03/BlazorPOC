using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterDesignation
    {
        public MasterDesignation()
        {
            QuickEnroll = new HashSet<QuickEnroll>();
        }

        public int DesignationId { get; set; }
        public string DesignationName { get; set; }
        public string DesignationDescription { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<QuickEnroll> QuickEnroll { get; set; }
    }
}
