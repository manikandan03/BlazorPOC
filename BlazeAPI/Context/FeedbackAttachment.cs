using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class FeedbackAttachment
    {
        public int FeedbackAttachmentId { get; set; }
        public int FeedbackId { get; set; }
        public Guid AttachmentId { get; set; }

        public virtual Attachment Attachment { get; set; }
        public virtual UserFeedback Feedback { get; set; }
    }
}
