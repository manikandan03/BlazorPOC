using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class CheckListMapping
    {
        public int CheckListMappingId { get; set; }
        public int ProjectId { get; set; }
        public int? CategoryId { get; set; }
        public int? CheckListId { get; set; }
        public bool? IsChecked { get; set; }

        public virtual Category Category { get; set; }
        public virtual CheckList CheckList { get; set; }
        public virtual Projects Project { get; set; }
    }
}
