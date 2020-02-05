using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ThirdPartyValues
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int ThirdPartyToolsId { get; set; }

        public virtual Projects Project { get; set; }
        public virtual MasterThirdParty ThirdPartyTools { get; set; }
    }
}
