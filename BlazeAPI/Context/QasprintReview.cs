using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class QasprintReview
    {
        public int Id { get; set; }
        public string Sprint { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public int? ProjectId { get; set; }
    }
}
