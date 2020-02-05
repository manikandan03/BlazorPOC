using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class DataBaseValues
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int DatabaseToolsId { get; set; }

        public virtual MasterDataBaseTechnolgy DatabaseTools { get; set; }
        public virtual Projects Project { get; set; }
    }
}
