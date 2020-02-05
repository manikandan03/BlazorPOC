using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class RaiseRequestRoleRelationShip
    {
        public int RaiseRequestRoleRelationShipId { get; set; }
        public int? RaiseRequestId { get; set; }
        public string RoleName { get; set; }
        public int? NoOfResourses { get; set; }
        public decimal? Avgexperience { get; set; }
        public int? AllocatedNoOfResourses { get; set; }
        public string UserId { get; set; }
        public DateTime? ExpectedStartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Skills { get; set; }
        public string Experience { get; set; }
        public int? ProjectUtilisation { get; set; }
        public bool? IsCompleted { get; set; }
        public bool? IsAdditional { get; set; }

        public virtual RaiseRequestDetails RaiseRequest { get; set; }
    }
}
