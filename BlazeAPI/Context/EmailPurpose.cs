using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class EmailPurpose
    {
        public int EmailPurposeId { get; set; }
        public string EmailPurposeName { get; set; }
        public int EmailTemplateId { get; set; }
        public string To { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string Subject { get; set; }
        public bool IsActive { get; set; }
        public int? EmailTemplateCategoryId { get; set; }
    }
}
