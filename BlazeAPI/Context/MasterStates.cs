using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterStates
    {
        public MasterStates()
        {
            MasterCity = new HashSet<MasterCity>();
        }

        public int StateId { get; set; }
        public string States { get; set; }
        public int? CountryId { get; set; }

        public virtual MasterCountry Country { get; set; }
        public virtual ICollection<MasterCity> MasterCity { get; set; }
    }
}
