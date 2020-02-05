using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class QuickAccessMenu
    {
        public QuickAccessMenu()
        {
            UserQuickAccessMenu = new HashSet<UserQuickAccessMenu>();
            UserRoleQuickAccessMenu = new HashSet<UserRoleQuickAccessMenu>();
        }

        public int QuickAccessMenuId { get; set; }
        public int? PageId { get; set; }
        public string IconStyleClass { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDefault { get; set; }

        public virtual Pages Page { get; set; }
        public virtual ICollection<UserQuickAccessMenu> UserQuickAccessMenu { get; set; }
        public virtual ICollection<UserRoleQuickAccessMenu> UserRoleQuickAccessMenu { get; set; }
    }
}
