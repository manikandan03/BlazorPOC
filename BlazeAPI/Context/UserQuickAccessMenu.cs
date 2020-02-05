using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class UserQuickAccessMenu
    {
        public int UserQuickAccessMenuId { get; set; }
        public int? QuickAccessMenuId { get; set; }
        public int? UserId { get; set; }
        public string DisplayName { get; set; }
        public bool? IsActive { get; set; }
        public int? ModBy { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual QuickAccessMenu QuickAccessMenu { get; set; }
    }
}
