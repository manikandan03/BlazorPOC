using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class CommunicationAttachment
    {
        public int CommunicationAttachmentId { get; set; }
        public int CommunicationId { get; set; }
        public Guid AttachmentId { get; set; }

        public virtual Attachment Attachment { get; set; }
        public virtual Communication Communication { get; set; }
    }
}
