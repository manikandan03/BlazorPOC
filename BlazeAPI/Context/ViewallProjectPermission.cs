using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ViewallProjectPermission
    {
        public int ProjectPermissionId { get; set; }
        public int? UserId { get; set; }
        public bool? IsAuthorized { get; set; }
    }
}
