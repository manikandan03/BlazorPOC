using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ReportingUsers
    {
        public int ReportingId { get; set; }
        public int? RoleId { get; set; }
        public int? UserId { get; set; }
    }
}
