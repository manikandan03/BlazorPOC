using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ViewEmail
    {
        public int Id { get; set; }
        public string FromEmail { get; set; }
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Attachment { get; set; }
        public string Sign { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? SentOn { get; set; }
        public string Attachmentpath { get; set; }
        public bool? CheckBox { get; set; }
        public string CcEmail { get; set; }
    }
}
