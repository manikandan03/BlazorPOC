using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ChildrensInformation
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string ChildName { get; set; }
        public DateTime? ChildDob { get; set; }
        public int? Gender { get; set; }
        public bool? Isactive { get; set; }

        public virtual MasterGender GenderNavigation { get; set; }
        public virtual Users User { get; set; }
    }
}
