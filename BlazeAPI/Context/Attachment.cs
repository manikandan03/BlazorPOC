using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class Attachment
    {
        public Attachment()
        {
            CommunicationAttachment = new HashSet<CommunicationAttachment>();
            FeedbackAttachment = new HashSet<FeedbackAttachment>();
            ItrequestAttachment = new HashSet<ItrequestAttachment>();
        }

        public Guid AttachmentId { get; set; }
        public int AttachmentTypeId { get; set; }
        public int UploadedUserId { get; set; }
        public DateTime UploadedDateTime { get; set; }
        public string FileName { get; set; }
        public bool IsDeleted { get; set; }

        public virtual AttachmentType AttachmentType { get; set; }
        public virtual Users UploadedUser { get; set; }
        public virtual ICollection<CommunicationAttachment> CommunicationAttachment { get; set; }
        public virtual ICollection<FeedbackAttachment> FeedbackAttachment { get; set; }
        public virtual ICollection<ItrequestAttachment> ItrequestAttachment { get; set; }
    }
}
