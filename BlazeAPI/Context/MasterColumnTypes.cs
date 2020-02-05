using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterColumnTypes
    {
        public int ColumnTypeId { get; set; }
        public string ColumnTypeName { get; set; }
        public bool? IsActive { get; set; }
    }
}
