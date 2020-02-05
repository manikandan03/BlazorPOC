using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ContactDetails
    {
        public int ContactDetailId { get; set; }
        public int? DepartmentId { get; set; }
        public int? UserId { get; set; }
        public long? ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public int? NearestExtension { get; set; }
        public int? LastAccessUserId { get; set; }
        public bool? IsActive { get; set; }
        public string PurposeDescription { get; set; }
    }
}
