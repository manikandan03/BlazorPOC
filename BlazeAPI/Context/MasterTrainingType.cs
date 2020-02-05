using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterTrainingType
    {
        public MasterTrainingType()
        {
            Training = new HashSet<Training>();
        }

        public int TrainingTypeId { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<Training> Training { get; set; }
    }
}
