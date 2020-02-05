using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterTechnologies
    {
        public MasterTechnologies()
        {
            TechnologyValues = new HashSet<TechnologyValues>();
        }

        public int Id { get; set; }
        public string Tecnology { get; set; }

        public virtual ICollection<TechnologyValues> TechnologyValues { get; set; }
    }
}
