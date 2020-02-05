using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ProjectUtilization
    {
        public int UtilizationId { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public int Utilization { get; set; }
        public bool? IsActive { get; set; }
    }
}
