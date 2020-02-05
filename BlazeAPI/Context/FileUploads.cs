using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class FileUploads
    {
        public int FileId { get; set; }
        public string Purpose { get; set; }
        public int? UploadBy { get; set; }
        public string FilePath { get; set; }
        public string Fname { get; set; }
    }
}
