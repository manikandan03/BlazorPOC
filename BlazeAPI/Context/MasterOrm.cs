using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterOrm
    {
        public MasterOrm()
        {
            Ormvalues = new HashSet<Ormvalues>();
        }

        public int Id { get; set; }
        public string OrmTools { get; set; }

        public virtual ICollection<Ormvalues> Ormvalues { get; set; }
    }
}
