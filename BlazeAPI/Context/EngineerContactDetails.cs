using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class EngineerContactDetails
    {
        public int ContactId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? UserId { get; set; }
        public long? ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public int? NearestExtension { get; set; }
        public string ShiftDetails { get; set; }
        public string DutyTime { get; set; }
        public int? LastAccessUserId { get; set; }
        public bool? IsActive { get; set; }
    }
}
