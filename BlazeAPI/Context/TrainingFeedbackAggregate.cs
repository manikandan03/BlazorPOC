using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class TrainingFeedbackAggregate
    {
        public int Faid { get; set; }
        public int TrainingId { get; set; }
        public double? TopicRating { get; set; }
        public double? RelevanceRating { get; set; }
        public double? CntAmtRating { get; set; }
        public double? LearnRating { get; set; }
        public double? PrepareRating { get; set; }
        public double? EgDemoRating { get; set; }
        public double? CntPresentRating { get; set; }
        public double? TimeRating { get; set; }
        public double? QualityRating { get; set; }
        public double? ContentRating { get; set; }
        public double? PresentRating { get; set; }
        public double? FacultyQrating { get; set; }
        public double? OverAllRating { get; set; }
        public int? NoOfAttendees { get; set; }
    }
}
