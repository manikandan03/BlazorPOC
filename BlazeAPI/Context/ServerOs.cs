using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ServerOs
    {
        public int ServerOsid { get; set; }
        public string ServerOsname { get; set; }
        public bool? IsActive { get; set; }
    }
}
