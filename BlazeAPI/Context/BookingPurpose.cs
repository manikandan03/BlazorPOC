using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class BookingPurpose
    {
        public int PurposeId { get; set; }
        public string PurposeName { get; set; }
        public bool IsActive { get; set; }
    }
}
