using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class DatabaseReport
    {
        public DatabaseReport()
        {
            DatabaseAccessDetail = new HashSet<DatabaseAccessDetail>();
        }

        public int DatabaseReportId { get; set; }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public int ProjectId { get; set; }
        public bool IsActive { get; set; }

        public virtual Projects Project { get; set; }
        public virtual ICollection<DatabaseAccessDetail> DatabaseAccessDetail { get; set; }
    }
}
