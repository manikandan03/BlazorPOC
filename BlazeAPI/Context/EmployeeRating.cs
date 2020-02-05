using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class EmployeeRating
    {
        public EmployeeRating()
        {
            EmployeeFeedbackQuestionAnswer = new HashSet<EmployeeFeedbackQuestionAnswer>();
            EmployeeRatingDetail = new HashSet<EmployeeRatingDetail>();
        }

        public int EmployeeRatingId { get; set; }
        public int UserId { get; set; }
        public int? ProjectId { get; set; }
        public int RatedByUserId { get; set; }
        public DateTime? FeedbackDate { get; set; }
        public string OverAllRating { get; set; }
        public string OverAllComments { get; set; }
        public int? RatingType { get; set; }
        public int? RatingMonth { get; set; }
        public bool? FeedbackSubmitted { get; set; }

        public virtual Users RatedByUser { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<EmployeeFeedbackQuestionAnswer> EmployeeFeedbackQuestionAnswer { get; set; }
        public virtual ICollection<EmployeeRatingDetail> EmployeeRatingDetail { get; set; }
    }
}
