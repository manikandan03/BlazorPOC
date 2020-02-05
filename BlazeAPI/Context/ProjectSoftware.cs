using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ProjectSoftware
    {
        public ProjectSoftware()
        {
            UserSoftwares = new HashSet<UserSoftwares>();
        }

        public int ProjectSoftwareId { get; set; }
        public int ProjectId { get; set; }
        public int SoftwareId { get; set; }
        public bool Isactive { get; set; }
        public DateTime RequestedDate { get; set; }

        public virtual Projects Project { get; set; }
        public virtual MasterSoftwares Software { get; set; }
        public virtual ICollection<UserSoftwares> UserSoftwares { get; set; }
    }
}
