using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class TimesheetType
    {
        public int TimesheetTypeId { get; set; }
        public int? ProjectId { get; set; }
        public bool? IsGrouped { get; set; }

        public virtual Projects Project { get; set; }
    }
}
