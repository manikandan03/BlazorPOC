using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterPriority
    {
        public MasterPriority()
        {
            Itrequest = new HashSet<Itrequest>();
        }

        public int Priorityid { get; set; }
        public string PriorityName { get; set; }
        public int? PriorityHour { get; set; }

        public virtual ICollection<Itrequest> Itrequest { get; set; }
    }
}
