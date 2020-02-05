using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterCategory
    {
        public MasterCategory()
        {
            Itrequest = new HashSet<Itrequest>();
        }

        public int Categoryid { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Itrequest> Itrequest { get; set; }
    }
}
