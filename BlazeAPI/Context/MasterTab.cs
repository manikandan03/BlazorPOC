using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterTab
    {
        public MasterTab()
        {
            ManageTab = new HashSet<ManageTab>();
        }

        public int TabId { get; set; }
        public string TabName { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<ManageTab> ManageTab { get; set; }
    }
}
