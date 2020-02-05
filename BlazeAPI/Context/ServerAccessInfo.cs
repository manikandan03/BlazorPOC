using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ServerAccessInfo
    {
        public int ServerAccessInfoId { get; set; }
        public int ServerId { get; set; }
        public int UserId { get; set; }
        public DateTime? RequestedDate { get; set; }
        public DateTime AssignedOn { get; set; }
        public DateTime ReleasedDate { get; set; }
        public bool? IsActive { get; set; }

        public virtual Server Server { get; set; }
        public virtual Users User { get; set; }
    }
}
