using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class EmployeeFeedbackQuestionAnswer
    {
        public int EmployeeFeedbackQuestionAnswerId { get; set; }
        public int EmployeeRatingId { get; set; }
        public int UserId { get; set; }
        public int? ProjectId { get; set; }
        public int FeedbackQuestionId { get; set; }
        public bool FeedbackQuestionAnswer { get; set; }
        public int AnsweredByUserId { get; set; }
        public DateTime? FeedbackDate { get; set; }

        public virtual Users AnsweredByUser { get; set; }
        public virtual EmployeeRating EmployeeRating { get; set; }
        public virtual MasterFeedBackQuestions FeedbackQuestion { get; set; }
        public virtual Users User { get; set; }
    }
}
