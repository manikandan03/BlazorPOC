using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class TrainingDeliveryLog
    {
        public TrainingDeliveryLog()
        {
            TrainingEmailLog = new HashSet<TrainingEmailLog>();
        }

        public int DeliveryLogId { get; set; }
        public int? TrainingId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? Isactive { get; set; }
        public int EmailTemplateId { get; set; }
        public int TrainingEmailPurposeId { get; set; }

        public virtual EmailTemplate EmailTemplate { get; set; }
        public virtual ICollection<TrainingEmailLog> TrainingEmailLog { get; set; }
    }
}
