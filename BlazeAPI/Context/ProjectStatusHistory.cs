using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ProjectStatusHistory
    {
        public byte Id { get; set; }
        public int ProjectId { get; set; }
        public int EnteredBy { get; set; }
        public int StatusId { get; set; }
        public DateTime EnteredDate { get; set; }

        public virtual Users EnteredByNavigation { get; set; }
        public virtual Projects Project { get; set; }
    }
}
