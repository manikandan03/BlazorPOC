using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class CheckList
    {
        public CheckList()
        {
            CheckListMapping = new HashSet<CheckListMapping>();
        }

        public int CheckListId { get; set; }
        public string CheckListName { get; set; }
        public int? CategoryId { get; set; }
        public bool? IsActive { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<CheckListMapping> CheckListMapping { get; set; }
    }
}
