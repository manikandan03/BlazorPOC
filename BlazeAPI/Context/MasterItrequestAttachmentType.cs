using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterItrequestAttachmentType
    {
        public MasterItrequestAttachmentType()
        {
            ItrequestAttachment = new HashSet<ItrequestAttachment>();
        }

        public int ItrequestAttachmentTypeId { get; set; }
        public string AttachmentTypeName { get; set; }

        public virtual ICollection<ItrequestAttachment> ItrequestAttachment { get; set; }
    }
}
