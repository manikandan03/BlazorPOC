using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class TrainingFeedBackCalc
    {
        public int FeedbackId { get; set; }
        public int? TrainingId { get; set; }
        public int? ChoiceTopic { get; set; }
        public int? PgmRelevance { get; set; }
        public int? ContentAmt { get; set; }
        public int? AdequacyLearning { get; set; }
        public int? AdequacyPreparation { get; set; }
        public int? ExampleDemo { get; set; }
        public int? ContentPresented { get; set; }
        public int? TimeMaintanence { get; set; }
        public int? FacultyQuality { get; set; }
        public bool? PgmUseful { get; set; }
        public string LearntInPgm { get; set; }
        public string Comments { get; set; }
        public int UserId { get; set; }
        public bool? Flag { get; set; }
        public DateTime? FeedBackSentOn { get; set; }
        public double? Overall { get; set; }
        public double? OverallPerc { get; set; }
        public int? ChoiceFaculty { get; set; }
        public int? FacultyAssistance { get; set; }
        public int? SkillDemonstration { get; set; }
        public int? TimeManagement { get; set; }
    }
}
