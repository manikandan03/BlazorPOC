using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ComputerAssigned
    {
        public int Assignid { get; set; }
        public int? Userid { get; set; }
        public int Managementid { get; set; }
        public int? Departmentid { get; set; }
        public string InsertedBy { get; set; }
        public bool? Isdelete { get; set; }
        public string DeletedBy { get; set; }
        public string LastEditedby { get; set; }
        public string ExtraDevices { get; set; }
        public int? Locationid { get; set; }
        public bool? PendriveAccess { get; set; }
        public bool? PendriveAccessnew { get; set; }
        public string WorkStation { get; set; }
        public string Upsid { get; set; }
        public string ComponentId { get; set; }
    }
}
