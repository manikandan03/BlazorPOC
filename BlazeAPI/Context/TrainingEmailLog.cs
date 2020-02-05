using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class TrainingEmailLog
    {
        public int TrainingEmailLog1 { get; set; }
        public int? UserId { get; set; }
        public string UserEmail { get; set; }
        public int? DeliveryLogId { get; set; }
        public DateTime? InsertedDate { get; set; }
        public DateTime? DeliveredDate { get; set; }
        public bool? IsSent { get; set; }
        public int? NoOfAttempts { get; set; }

        public virtual TrainingDeliveryLog DeliveryLog { get; set; }
        public virtual Users User { get; set; }
    }
}
