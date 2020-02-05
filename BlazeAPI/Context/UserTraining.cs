using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class UserTraining
    {
        public int UserTrainingId { get; set; }
        public int? UserId { get; set; }
        public int TrainingId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? IsActive { get; set; }

        public virtual Users User { get; set; }
    }
}
