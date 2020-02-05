using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class UserDeviceHistory
    {
        public int DeviceHistoryId { get; set; }
        public int? DeviceId { get; set; }
        public int? Userid { get; set; }
        public int? AssignedTo { get; set; }
        public DateTime? RequestedDate { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public DateTime? ReleasedDate { get; set; }
        public int? TotalHours { get; set; }
        public int? DeviceStatus { get; set; }
        public int? RequestedBy { get; set; }

        public virtual DeviceManagement Device { get; set; }
        public virtual MasterDeviceStatus DeviceStatusNavigation { get; set; }
    }
}
