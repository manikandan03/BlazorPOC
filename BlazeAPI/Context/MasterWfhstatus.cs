using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterWfhstatus
    {
        public MasterWfhstatus()
        {
            OutOfOfficeDetails = new HashSet<OutOfOfficeDetails>();
        }

        public byte StatusId { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<OutOfOfficeDetails> OutOfOfficeDetails { get; set; }
    }
}
