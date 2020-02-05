using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class AttachmentType
    {
        public AttachmentType()
        {
            Attachment = new HashSet<Attachment>();
        }

        public int AttachmentTypeId { get; set; }
        public string FolderName { get; set; }

        public virtual ICollection<Attachment> Attachment { get; set; }
    }
}
