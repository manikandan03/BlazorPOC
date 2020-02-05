using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class PermanentAddress
    {
        public int PermanentAddressId { get; set; }
        public int? UserId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? Zip { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? IsActive { get; set; }
        public int? CountryId { get; set; }

        public virtual Users User { get; set; }
    }
}
