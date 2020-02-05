using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class StarPerformanceDetails
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string MonthandYear { get; set; }
        public string Reason { get; set; }

        public virtual Users User { get; set; }
    }
}
