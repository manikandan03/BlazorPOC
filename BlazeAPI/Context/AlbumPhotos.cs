using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class AlbumPhotos
    {
        public int AlbumPhotoId { get; set; }
        public string AlbumPhotoTitle { get; set; }
        public string AlbumPhotoDescription { get; set; }
        public string AlbumPhotoPath { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public bool? IsActive { get; set; }
        public int? AlbumId { get; set; }

        public virtual Album Album { get; set; }
    }
}
