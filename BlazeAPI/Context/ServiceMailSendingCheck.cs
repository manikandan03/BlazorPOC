using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ServiceMailSendingCheck
    {
        public int Checkid { get; set; }
        public string MailTemplateName { get; set; }
        public DateTime? MailSentDate { get; set; }
        public bool? Issent { get; set; }
    }
}
