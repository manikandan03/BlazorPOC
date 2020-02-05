using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterReportType
    {
        public MasterReportType()
        {
            QareportQuestions = new HashSet<QareportQuestions>();
        }

        public int ReportTypeId { get; set; }
        public string ReportTypeDescription { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<QareportQuestions> QareportQuestions { get; set; }
    }
}
