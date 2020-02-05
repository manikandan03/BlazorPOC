using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterThirdParty
    {
        public MasterThirdParty()
        {
            ThirdPartyValues = new HashSet<ThirdPartyValues>();
        }

        public int Id { get; set; }
        public string ThirdPartyTools { get; set; }

        public virtual ICollection<ThirdPartyValues> ThirdPartyValues { get; set; }
    }
}
