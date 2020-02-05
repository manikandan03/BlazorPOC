using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class TechnologyValues
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public int? TecnologyId { get; set; }

        public virtual MasterTechnologies Tecnology { get; set; }
    }
}
