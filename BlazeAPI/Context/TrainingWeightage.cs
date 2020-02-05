using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class TrainingWeightage
    {
        public int WeightageId { get; set; }
        public int? LevelId { get; set; }
        public int? TrainingTypeid { get; set; }
        public int? Trainee { get; set; }
        public int? Instructor { get; set; }
        public int? Supporter { get; set; }
    }
}
