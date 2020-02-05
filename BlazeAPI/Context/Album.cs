using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class Album
    {
        public Album()
        {
            AlbumPhotos = new HashSet<AlbumPhotos>();
            TaggedAlbums = new HashSet<TaggedAlbums>();
        }

        public int AlbumId { get; set; }
        public string AlbumTitle { get; set; }
        public string AlbumDescription { get; set; }
        public string AlbumCoverPhotoPath { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? EventDate { get; set; }

        public virtual ICollection<AlbumPhotos> AlbumPhotos { get; set; }
        public virtual ICollection<TaggedAlbums> TaggedAlbums { get; set; }
    }
}
