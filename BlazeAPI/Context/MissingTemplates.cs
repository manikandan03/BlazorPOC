using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MissingTemplates
    {
        public int MissingTemplateId { get; set; }
        public string TemplateName { get; set; }
        public string MissedProcess { get; set; }
        public string ProcessedBy { get; set; }
        public DateTime? ProcessedDate { get; set; }
    }
}
