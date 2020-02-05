using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterCity
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int? StateId { get; set; }

        public virtual MasterStates State { get; set; }
    }
}
