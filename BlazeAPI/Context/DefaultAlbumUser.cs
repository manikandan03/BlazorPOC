using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class DefaultAlbumUser
    {
        public int AccessId { get; set; }
        public int AlbumId { get; set; }
        public int UserId { get; set; }
        public bool? IsActive { get; set; }
    }
}
