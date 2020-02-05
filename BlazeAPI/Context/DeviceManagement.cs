using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class DeviceManagement
    {
        public DeviceManagement()
        {
            UserDeviceHistory = new HashSet<UserDeviceHistory>();
        }

        public int DeviceId { get; set; }
        public string DeviceName { get; set; }
        public string Model { get; set; }
        public int? AssignedTo { get; set; }
        public DateTime? AssignedOn { get; set; }
        public bool? IsActive { get; set; }
        public int? AuthorizedPerson { get; set; }
        public string DeviceDescription { get; set; }
        public bool? InStoreflag { get; set; }
        public string TrackingId { get; set; }

        public virtual ICollection<UserDeviceHistory> UserDeviceHistory { get; set; }
    }
}
