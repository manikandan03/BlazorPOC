using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class RemainingEarnedLeaves
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Year { get; set; }
        public double? AvailableEarnedLeaves { get; set; }
        public double? AllowedDays { get; set; }
    }
}
