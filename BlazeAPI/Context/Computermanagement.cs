using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class Computermanagement
    {
        public int Managementid { get; set; }
        public string Manufacturer { get; set; }
        public string Cpuid { get; set; }
        public string MonitorId { get; set; }
        public string Os { get; set; }
        public string Memory { get; set; }
        public string ComputerName { get; set; }
        public bool? Isdelete { get; set; }
        public string DeletedBy { get; set; }
        public string LastEditedby { get; set; }
        public string InsertedBy { get; set; }
        public string Cpu { get; set; }
        public bool? ComputerStatus { get; set; }
        public string Ip { get; set; }
        public string ComputerStatusNew { get; set; }
        public int? OsId { get; set; }
        public int? CpuIdNew { get; set; }
    }
}
