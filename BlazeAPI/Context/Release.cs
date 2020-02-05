using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class Release
    {
        public short ReleaseId { get; set; }
        public string Version { get; set; }
        public string VersionLabel { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
