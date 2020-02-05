using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterFeedBackQuestions
    {
        public MasterFeedBackQuestions()
        {
            EmployeeFeedbackQuestionAnswer = new HashSet<EmployeeFeedbackQuestionAnswer>();
        }

        public int FeedbackQuestionId { get; set; }
        public string FeedbackQuestion { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual ICollection<EmployeeFeedbackQuestionAnswer> EmployeeFeedbackQuestionAnswer { get; set; }
    }
}
