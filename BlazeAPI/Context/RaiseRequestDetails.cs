using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class RaiseRequestDetails
    {
        public RaiseRequestDetails()
        {
            RaiseRequestRoleRelationShip = new HashSet<RaiseRequestRoleRelationShip>();
        }

        public int RaiseRequestId { get; set; }
        public string ProjectLeadName { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public bool? Status { get; set; }
        public bool? IsDelete { get; set; }
        public int? RaisedBy { get; set; }
        public int? ProjectLeadId { get; set; }

        public virtual ICollection<RaiseRequestRoleRelationShip> RaiseRequestRoleRelationShip { get; set; }
    }
}
