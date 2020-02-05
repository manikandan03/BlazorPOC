using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ServerPort
    {
        public int ServerPortId { get; set; }
        public int ServerId { get; set; }
        public string ExternalIp { get; set; }
        public string ExternalPort { get; set; }
        public string InternalPort { get; set; }
        public string InternalIp { get; set; }
        public string Dnsname { get; set; }
        public DateTime? AssignedDate { get; set; }
        public string Comments { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual Server Server { get; set; }
    }
}
