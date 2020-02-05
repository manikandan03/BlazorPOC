using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class Expenditure
    {
        public int ExpenseId { get; set; }
        public string ExpenseDescription { get; set; }
        public DateTime? ExpenseDate { get; set; }
        public double? ExpenseAmount { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
