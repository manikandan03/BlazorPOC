using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class GetClientVisitForm
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string EmpId { get; set; }
        public string Client { get; set; }
        public string ClientCompany { get; set; }
        public string ClientMailId { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string PurposeOfVisit { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public bool? Isactive { get; set; }
        public int? Status { get; set; }
        public int? ReportingTo { get; set; }
    }
}
