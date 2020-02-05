using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class EmailTemplate
    {
        public EmailTemplate()
        {
            TrainingDeliveryLog = new HashSet<TrainingDeliveryLog>();
        }

        public int EmailTemplateId { get; set; }
        public string TemplatePath { get; set; }
        public string TemplatePurpose { get; set; }
        public bool IsActive { get; set; }
        public string ModuleName { get; set; }
        public string TemplateContent { get; set; }

        public virtual ICollection<TrainingDeliveryLog> TrainingDeliveryLog { get; set; }
    }
}
