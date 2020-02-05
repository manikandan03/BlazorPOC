using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterCountry
    {
        public MasterCountry()
        {
            MasterStates = new HashSet<MasterStates>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<MasterStates> MasterStates { get; set; }
    }
}
