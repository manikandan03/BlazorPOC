using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class DatabaseAccessDetail
    {
        public int DatabaseAccessDetailId { get; set; }
        public int DatabaseReportId { get; set; }
        public int UserId { get; set; }
        public DateTime Createddate { get; set; }
        public bool IsActive { get; set; }

        public virtual DatabaseReport DatabaseReport { get; set; }
        public virtual Users User { get; set; }
    }
}
