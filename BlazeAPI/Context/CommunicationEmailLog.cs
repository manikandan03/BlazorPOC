using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class CommunicationEmailLog
    {
        public int CommunicationEmailLog1 { get; set; }
        public int? CommunicationId { get; set; }
        public int? UserId { get; set; }
        public string UserEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string MailDroppedEmployeeName { get; set; }
        public DateTime? InsertedDate { get; set; }
        public DateTime? DeliveredDate { get; set; }
        public bool? IsSent { get; set; }
        public int? NoOfAttempts { get; set; }

        public virtual Users User { get; set; }
    }
}
