using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterUserStatus
    {
        public int UserStatusId { get; set; }
        public string UserStatus { get; set; }
        public bool? IsActive { get; set; }
    }
}
