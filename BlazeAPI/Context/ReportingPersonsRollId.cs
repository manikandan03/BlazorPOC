using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ReportingPersonsRollId
    {
        public int Id { get; set; }
        public byte? ReportingPersonRollId { get; set; }

        public virtual MasterRoles ReportingPersonRoll { get; set; }
    }
}
