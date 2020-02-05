using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MileStoneValues
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int MileStoneId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? ActualEndDate { get; set; }

        public virtual MasterMileStones MileStone { get; set; }
        public virtual Projects Project { get; set; }
    }
}
