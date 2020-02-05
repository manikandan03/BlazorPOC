using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class AddHoliday
    {
        public int HolidayId { get; set; }
        public string HolidayName { get; set; }
        public int? ZoneId { get; set; }
        public DateTime? Date { get; set; }
        public string EnteredBy { get; set; }
        public bool? Isactive { get; set; }
        public bool? IsRestriced { get; set; }
    }
}
