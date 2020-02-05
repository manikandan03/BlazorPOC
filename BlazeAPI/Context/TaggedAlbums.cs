using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class TaggedAlbums
    {
        public int TaggedAlbumId { get; set; }
        public int? AlbumId { get; set; }
        public int? UserId { get; set; }

        public virtual Album Album { get; set; }
        public virtual Users User { get; set; }
    }
}
