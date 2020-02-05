using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class Pages
    {
        public Pages()
        {
            ModulePages = new HashSet<ModulePages>();
            QuickAccessMenu = new HashSet<QuickAccessMenu>();
        }

        public int PageId { get; set; }
        public string PageName { get; set; }
        public string PageUrl { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual ICollection<ModulePages> ModulePages { get; set; }
        public virtual ICollection<QuickAccessMenu> QuickAccessMenu { get; set; }
    }
}
