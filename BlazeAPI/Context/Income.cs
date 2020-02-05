using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class Income
    {
        public int IncomeId { get; set; }
        public string IncomeDescription { get; set; }
        public DateTime? IncomeDate { get; set; }
        public double? IncomeAmount { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
