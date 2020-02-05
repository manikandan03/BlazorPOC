using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class QareportQuestionAnswers
    {
        public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        public string AnswerDescription { get; set; }
        public DateTime AnswerCreatedDate { get; set; }
        public bool? AnswerType { get; set; }
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public bool Isactive { get; set; }
        public DateTime? Submitteddate { get; set; }
        public int? SprintId { get; set; }
        public int? ReviewWeekId { get; set; }

        public virtual Projects Project { get; set; }
        public virtual QareportQuestions Question { get; set; }
        public virtual MasterWeeks ReviewWeek { get; set; }
        public virtual Users User { get; set; }
    }
}
