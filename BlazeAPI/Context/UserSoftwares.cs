using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class UserSoftwares
    {
        public int UserSoftwareId { get; set; }
        public int ProjectSoftwareId { get; set; }
        public int UserId { get; set; }
        public bool Isactive { get; set; }
        public DateTime RequestedDate { get; set; }

        public virtual ProjectSoftware ProjectSoftware { get; set; }
        public virtual Users User { get; set; }
    }
}
