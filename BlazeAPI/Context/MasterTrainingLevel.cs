using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterTrainingLevel
    {
        public MasterTrainingLevel()
        {
            Training = new HashSet<Training>();
        }

        public int LevelId { get; set; }
        public string LevelName { get; set; }

        public virtual ICollection<Training> Training { get; set; }
    }
}
