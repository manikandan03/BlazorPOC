using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterTrainingStatus
    {
        public MasterTrainingStatus()
        {
            Training = new HashSet<Training>();
        }

        public int StatusId { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<Training> Training { get; set; }
    }
}
