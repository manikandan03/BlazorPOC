using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class Server
    {
        public Server()
        {
            ServerAccessInfo = new HashSet<ServerAccessInfo>();
            ServerPatchInfo = new HashSet<ServerPatchInfo>();
            ServerPort = new HashSet<ServerPort>();
        }

        public int ServerId { get; set; }
        public string AssetId { get; set; }
        public string ServerName { get; set; }
        public string ServerDescription { get; set; }
        public string IpAddresss { get; set; }
        public string Type { get; set; }
        public int? FloorId { get; set; }
        public bool? IsInternal { get; set; }
        public int? Os { get; set; }
        public string Processor { get; set; }
        public string Ram { get; set; }
        public string Hddsize { get; set; }
        public string RackNo { get; set; }
        public string ServerMake { get; set; }
        public string ServerModel { get; set; }
        public string Raid { get; set; }
        public string ServerEdition { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsActive { get; set; }
        public int? AssignToId { get; set; }
        public string ProjectIds { get; set; }
        public string Connection { get; set; }
        public string Port { get; set; }

        public virtual Users AssignTo { get; set; }
        public virtual ICollection<ServerAccessInfo> ServerAccessInfo { get; set; }
        public virtual ICollection<ServerPatchInfo> ServerPatchInfo { get; set; }
        public virtual ICollection<ServerPort> ServerPort { get; set; }
    }
}
