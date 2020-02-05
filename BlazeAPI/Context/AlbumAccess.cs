using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class AlbumAccess
    {
        public int AlbumAccessId { get; set; }
        public int? AlbumId { get; set; }
        public int? RoleId { get; set; }
        public int? UserId { get; set; }
    }
}
