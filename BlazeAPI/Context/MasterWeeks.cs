using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterWeeks
    {
        public MasterWeeks()
        {
            QaprojectRagStatus = new HashSet<QaprojectRagStatus>();
            QareportQuestionAnswers = new HashSet<QareportQuestionAnswers>();
        }

        public int WeekId { get; set; }
        public string Legends { get; set; }

        public virtual ICollection<QaprojectRagStatus> QaprojectRagStatus { get; set; }
        public virtual ICollection<QareportQuestionAnswers> QareportQuestionAnswers { get; set; }
    }
}
