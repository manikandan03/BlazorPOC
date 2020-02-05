using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class UsersFeedback
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Feedback { get; set; }
        public DateTime FeedbackDate { get; set; }

        public virtual Users User { get; set; }
    }
}
