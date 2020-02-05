using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterDataBaseTechnolgy
    {
        public MasterDataBaseTechnolgy()
        {
            DataBaseValues = new HashSet<DataBaseValues>();
        }

        public int Id { get; set; }
        public string DatabaseTools { get; set; }

        public virtual ICollection<DataBaseValues> DataBaseValues { get; set; }
    }
}
