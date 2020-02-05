using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterTrainingTechnology
    {
        public MasterTrainingTechnology()
        {
            Training = new HashSet<Training>();
            TrainingMailPurpose = new HashSet<TrainingMailPurpose>();
        }

        public int TechnologyId { get; set; }
        public string TechnologyName { get; set; }

        public virtual ICollection<Training> Training { get; set; }
        public virtual ICollection<TrainingMailPurpose> TrainingMailPurpose { get; set; }
    }
}
