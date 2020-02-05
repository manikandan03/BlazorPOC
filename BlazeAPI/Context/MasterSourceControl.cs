using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterSourceControl
    {
        public MasterSourceControl()
        {
            SourceControlValues = new HashSet<SourceControlValues>();
        }

        public int Id { get; set; }
        public string SourceControlTools { get; set; }

        public virtual ICollection<SourceControlValues> SourceControlValues { get; set; }
    }
}
