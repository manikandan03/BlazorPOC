using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ItrequestAttachment
    {
        public int ItrequestAttachmentId { get; set; }
        public int ItrequestId { get; set; }
        public int ItrequestAttachmentTypeId { get; set; }
        public Guid AttachmentId { get; set; }

        public virtual Attachment Attachment { get; set; }
        public virtual Itrequest Itrequest { get; set; }
        public virtual MasterItrequestAttachmentType ItrequestAttachmentType { get; set; }
    }
}
