using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class CalendarYear
    {
        public byte CalendarYearId { get; set; }
        public byte? StartingMonth { get; set; }
        public byte? EndingMonth { get; set; }
    }
}
