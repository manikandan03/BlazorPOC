using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterHoliday
    {
        public byte HolidayId { get; set; }
        public string Detail { get; set; }
        public DateTime? Date { get; set; }
    }
}
