using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class UserFeedback
    {
        public UserFeedback()
        {
            FeedbackAttachment = new HashSet<FeedbackAttachment>();
            FeedbackComments = new HashSet<FeedbackComments>();
        }

        public int UserFeedbackId { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsClosed { get; set; }
        public bool? IsReplied { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<FeedbackAttachment> FeedbackAttachment { get; set; }
        public virtual ICollection<FeedbackComments> FeedbackComments { get; set; }
    }
}
