using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class AuditLog
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LoginId { get; set; }
        public string Roles { get; set; }
        public DateTime? LogedInDate { get; set; }
        public DateTime? LoggedOutDate { get; set; }
        public string IpAddress { get; set; }
        public string BrowserVersion { get; set; }
        public string OsVersion { get; set; }
        public string Location { get; set; }
    }
}
