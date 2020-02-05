using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class SourceControlValues
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int SourceControlId { get; set; }

        public virtual Projects Project { get; set; }
        public virtual MasterSourceControl SourceControl { get; set; }
    }
}
