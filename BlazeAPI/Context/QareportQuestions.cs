using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class QareportQuestions
    {
        public QareportQuestions()
        {
            QareportQuestionAnswers = new HashSet<QareportQuestionAnswers>();
        }

        public int QuestionId { get; set; }
        public string QuestionDescription { get; set; }
        public int QuestionTypeId { get; set; }
        public int ReportTypeId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int MemberTypeId { get; set; }
        public bool IsActive { get; set; }
        public int? ProjectTypeId { get; set; }

        public virtual MasterMemberTypes MemberType { get; set; }
        public virtual MasterProjectTypes ProjectType { get; set; }
        public virtual QareportQuestionType QuestionType { get; set; }
        public virtual MasterReportType ReportType { get; set; }
        public virtual ICollection<QareportQuestionAnswers> QareportQuestionAnswers { get; set; }
    }
}
