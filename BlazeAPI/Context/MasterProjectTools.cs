using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterProjectTools
    {
        public MasterProjectTools()
        {
            ProjectToolDetail = new HashSet<ProjectToolDetail>();
        }

        public int ProjectToolId { get; set; }
        public string ProjectToolName { get; set; }
        public bool Isactive { get; set; }

        public virtual ICollection<ProjectToolDetail> ProjectToolDetail { get; set; }
    }
}
