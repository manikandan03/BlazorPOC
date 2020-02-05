using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterItstatus
    {
        public MasterItstatus()
        {
            Itrequest = new HashSet<Itrequest>();
        }

        public int StatusId { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Itrequest> Itrequest { get; set; }
    }
}
