using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterFloor
    {
        public MasterFloor()
        {
            ConferenceRoom = new HashSet<ConferenceRoom>();
        }

        public int FloorId { get; set; }
        public string FloorName { get; set; }

        public virtual ICollection<ConferenceRoom> ConferenceRoom { get; set; }
    }
}
