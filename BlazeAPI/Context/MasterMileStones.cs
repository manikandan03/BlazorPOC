using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterMileStones
    {
        public MasterMileStones()
        {
            MileStoneValues = new HashSet<MileStoneValues>();
        }

        public int MileStoneId { get; set; }
        public string MileStoneName { get; set; }

        public virtual ICollection<MileStoneValues> MileStoneValues { get; set; }
    }
}
