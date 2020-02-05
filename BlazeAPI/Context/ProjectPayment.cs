using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ProjectPayment
    {
        public int PaymentId { get; set; }
        public string CustomerName { get; set; }
        public int? TermType { get; set; }
        public double? Amount { get; set; }
        public bool? IsActive { get; set; }
        public int? Branch { get; set; }
        public int? Department { get; set; }
        public int? DepartmentGroup { get; set; }
    }
}
