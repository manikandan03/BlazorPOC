using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class EmployeeRevokeEmailLog
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string LastworkingDate { get; set; }
        public bool? IsSent { get; set; }
    }
}
