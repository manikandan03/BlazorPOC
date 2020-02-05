using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterSoftwares
    {
        public MasterSoftwares()
        {
            ProjectSoftware = new HashSet<ProjectSoftware>();
        }

        public int SoftwareId { get; set; }
        public string SoftwareName { get; set; }

        public virtual ICollection<ProjectSoftware> ProjectSoftware { get; set; }
    }
}
