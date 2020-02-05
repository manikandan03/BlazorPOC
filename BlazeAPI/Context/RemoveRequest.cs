using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class RemoveRequest
    {
        public int RequestId { get; set; }
        public int UserProjectId { get; set; }
        public int ProjectId { get; set; }
        public int RequestedUserId { get; set; }
        public int DeliverymanagerId { get; set; }
        public bool IsRemoved { get; set; }
        public DateTime Date { get; set; }

        public virtual Projects Project { get; set; }
        public virtual UserProjects UserProject { get; set; }
    }
}
