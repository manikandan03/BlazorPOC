using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class Communication
    {
        public Communication()
        {
            CommunicationAttachment = new HashSet<CommunicationAttachment>();
        }

        public int CommunicationId { get; set; }
        public int SendByUserId { get; set; }
        public int SentMailType { get; set; }
        public string ExeculdeUserIdList { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ScheduledDate { get; set; }
        public bool Isactive { get; set; }
        public bool IsMailSent { get; set; }
        public string SelectedList { get; set; }

        public virtual Users SendByUser { get; set; }
        public virtual ICollection<CommunicationAttachment> CommunicationAttachment { get; set; }
    }
}
