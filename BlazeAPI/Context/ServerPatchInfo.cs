using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ServerPatchInfo
    {
        public int ServerPatchInfoId { get; set; }
        public int ServerId { get; set; }
        public string PatchName { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }

        public virtual Server Server { get; set; }
    }
}
