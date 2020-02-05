using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class Ormvalues
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int OrmToolsId { get; set; }

        public virtual MasterOrm OrmTools { get; set; }
        public virtual Projects Project { get; set; }
    }
}
