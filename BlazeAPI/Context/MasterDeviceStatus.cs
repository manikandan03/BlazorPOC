using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterDeviceStatus
    {
        public MasterDeviceStatus()
        {
            UserDeviceHistory = new HashSet<UserDeviceHistory>();
        }

        public int DeviceStatusId { get; set; }
        public string DeviceStatus { get; set; }

        public virtual ICollection<UserDeviceHistory> UserDeviceHistory { get; set; }
    }
}
