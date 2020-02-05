using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterGender
    {
        public MasterGender()
        {
            ChildrensInformation = new HashSet<ChildrensInformation>();
            QuickEnroll = new HashSet<QuickEnroll>();
        }

        public int GenderId { get; set; }
        public string GenderName { get; set; }

        public virtual ICollection<ChildrensInformation> ChildrensInformation { get; set; }
        public virtual ICollection<QuickEnroll> QuickEnroll { get; set; }
    }
}
