using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class TempUsers
    {
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmpId { get; set; }
        public int? BranchId { get; set; }
        public int? Department { get; set; }
    }
}
