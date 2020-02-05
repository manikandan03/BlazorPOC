using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class AlbumPermission
    {
        public int AlbumPermissionId { get; set; }
        public int? UserId { get; set; }
        public bool? IsAuthorized { get; set; }
    }
}
