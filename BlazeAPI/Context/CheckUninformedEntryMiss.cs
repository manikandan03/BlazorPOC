using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class CheckUninformedEntryMiss
    {
        public DateTime Date { get; set; }
        public bool? IsActive { get; set; }
        public bool? Issent { get; set; }
    }
}
