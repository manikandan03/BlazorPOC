using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class Trainingabsenteesreason
    {
        public int Reasonid { get; set; }
        public string Reason { get; set; }
        public int? Userid { get; set; }
        public int? Trainingid { get; set; }
        public bool? Flag { get; set; }

        public virtual Training Training { get; set; }
        public virtual Users User { get; set; }
    }
}
