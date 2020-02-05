using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ConfirmationFeedback
    {
        public int FeedbackId { get; set; }
        public int? UserId { get; set; }
        public int? ReportingUserId { get; set; }
        public int? Attendance { get; set; }
        public int? Quality { get; set; }
        public int? ClientCordination { get; set; }
        public int? TeamCordination { get; set; }
        public int? Delivery { get; set; }
        public int? Initiative { get; set; }
        public int? Conduct { get; set; }
        public int? Behavior { get; set; }
        public int? Presentability { get; set; }
        public int? Communication { get; set; }
        public int? Oral { get; set; }
        public int? Written { get; set; }
        public int? Chances { get; set; }
        public string Learned { get; set; }
        public string Appreciation { get; set; }
        public string OtherComments { get; set; }
        public bool FeedbackPopUp { get; set; }
        public bool FeedbackNow { get; set; }
        public bool FeedbackLater { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? ExtendedDate { get; set; }
        public string Description { get; set; }
    }
}
