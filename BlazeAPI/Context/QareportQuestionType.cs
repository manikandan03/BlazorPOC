using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class QareportQuestionType
    {
        public QareportQuestionType()
        {
            QareportQuestions = new HashSet<QareportQuestions>();
        }

        public int QuestionTypeId { get; set; }
        public string QuestionTypeDescription { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<QareportQuestions> QareportQuestions { get; set; }
    }
}
