using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class EmployeeEditedDetails
    {
        public int Id { get; set; }
        public DateTime? LastAccessedDate { get; set; }
        public string FieldsAccessed { get; set; }
        public int? LastAccessedFor { get; set; }
        public int? LastAccessedBy { get; set; }

        public virtual Users LastAccessedByNavigation { get; set; }
    }
}
